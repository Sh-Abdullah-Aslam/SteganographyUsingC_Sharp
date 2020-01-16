using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessLogicLayer
{
    public class SteaganographyEncoding
    {
        private static string fixedLengthEncoding(string textToEncode)
        {
            // String to save encoded msg
            string encodedString = string.Empty;

            List<char> charactersInTextToEncode = new List<char>();

            for (int index = 0; index < textToEncode.Length; index++)
            {
                if (!(charactersInTextToEncode.Contains(textToEncode[index])))
                {
                    charactersInTextToEncode.Add(textToEncode[index]);
                }
            }

            int lengthOfEachCharacter = Convert.ToString(charactersInTextToEncode.Count, 2).Length;

            Dictionary<char, string> keyAndValueOfEachChar = new Dictionary<char, string>();
            string valueAfterConversion = string.Empty;

            // Make a key value pair for 
            int iterator = 0;
            foreach (char characterInTextToEncode in charactersInTextToEncode)
            {
                valueAfterConversion = Convert.ToString(iterator, 2).PadLeft(lengthOfEachCharacter, '0');
                keyAndValueOfEachChar.Add(characterInTextToEncode, valueAfterConversion);

                iterator++;
            }

            // First 16 characters define the length of each encoded character
            encodedString = Convert.ToString(lengthOfEachCharacter, 2).PadLeft(16, '0');

            // Then 16 characters define the number of characters encoded
            encodedString += Convert.ToString(charactersInTextToEncode.Count, 2).PadLeft(16, '0');

            // Then each character is encoded
            foreach (char character in charactersInTextToEncode)
            {
                // Storing each encoded character
                encodedString += keyAndValueOfEachChar[character];

                // Storing 8 bit value of each encoded character
                int integerValueOfCharacter = (int)character;
                string eightBitValueOfCharacter = Convert.ToString(integerValueOfCharacter, 2).PadLeft(8, '0');
                encodedString += eightBitValueOfCharacter;
            }

            // Lastly, encode the message
            foreach (char character in textToEncode)
            {
                encodedString += keyAndValueOfEachChar[character];
            }

            return encodedString;
        }

        private static string fixedLengthDecoding(string textToDecode)
        {
            string decodedString = string.Empty;

            // Get first 16 characters and parse them to get length of each encoded character
            string lengthOfEachEncodedCharacterInString = textToDecode.Substring(0, 16);
            int lengthOfEachEncodedCharacter = Convert.ToInt32(lengthOfEachEncodedCharacterInString, 2);

            // Get next 16 characters and parse them to get the number of encoded characters
            string noOfCharactersEncodedInString = textToDecode.Substring(16, 16);
            int noOfCharactersEncoded = Convert.ToInt32(noOfCharactersEncodedInString, 2);

            Dictionary<string, char> keyAndValueOfEachChar = new Dictionary<string, char>();

            string decodedCharacterHuffmanValue;
            char decodedCharacterAsciiValue;

            int loopCount = 32 + lengthOfEachEncodedCharacter * noOfCharactersEncoded + (noOfCharactersEncoded * 8);

            for (int index = 32; index < loopCount; index += (lengthOfEachEncodedCharacter + 8))
            {
                decodedCharacterHuffmanValue = textToDecode.Substring(index, lengthOfEachEncodedCharacter);
                decodedCharacterAsciiValue = (char)Convert.ToInt32(textToDecode.Substring(index + lengthOfEachEncodedCharacter, 8), 2);

                if (!keyAndValueOfEachChar.ContainsKey(decodedCharacterHuffmanValue))
                {
                    keyAndValueOfEachChar.Add(decodedCharacterHuffmanValue, decodedCharacterAsciiValue);
                }
            }

            // To get the actual message, skip all the previous bits
            int iterator = loopCount;
            for (; iterator < textToDecode.Length; iterator += lengthOfEachEncodedCharacter)
            {
                decodedString += keyAndValueOfEachChar[textToDecode.Substring(iterator, lengthOfEachEncodedCharacter)];
            }

            return decodedString;
        }

        private static bool isEven(byte colorIntensity)
        {
            return (colorIntensity % 2 == 0) ? true : false;
        }

        public static Bitmap SteganoImage(Image rawImage, string rawText)
        {
            // Local functions
            bool isOne(char characterPassed)
            {
                return (characterPassed == '1') ? true : false;
            }
            void encodeDelimiterPattern(Bitmap bitmapOfImage)
            {
                /* Embedding this pattern 111111110000000011110000
                    at the first row of image */

                byte localRed = 0;
                Color pixel = new Color();

                // Embed this pattern : 11111111 (Eight 1's)
                for (int j = 0; j < 8; j++)
                {
                    pixel = bitmapOfImage.GetPixel(0, j);
                    localRed = pixel.R;
                    if (localRed != 255)
                    {
                        if (!isEven(localRed))
                        {
                            pixel = Color.FromArgb(localRed + 1, pixel.G, pixel.B);
                            bitmapOfImage.SetPixel(0, j, pixel);
                        }
                        // Else leave as it is because there is no need to change the value
                        // as it is already one
                    }
                    else
                    {
                        pixel = Color.FromArgb(localRed - 1, pixel.G, pixel.B);
                        bitmapOfImage.SetPixel(0, j, pixel);
                    }
                }

                // Embed this pattern : 00000000 (Eight 0's)
                for (int j = 8; j < 16; j++)
                {
                    pixel = bitmapOfImage.GetPixel(0, j);
                    localRed = pixel.R;
                    if (localRed != 255)
                    {
                        if (isEven(localRed))
                        {
                            pixel = Color.FromArgb(localRed + 1, pixel.G, pixel.B);
                            bitmapOfImage.SetPixel(0, j, pixel);
                        }
                        // Else leave as it is because there is no need to change the value
                        // as it is already zero
                    }
                    // Else leave as it is as 255 is already odd
                }

                // Embed this pattern : 1111 (Four 1's)
                for (int j = 16; j < 20; j++)
                {
                    pixel = bitmapOfImage.GetPixel(0, j);
                    localRed = pixel.R;
                    if (localRed != 255)
                    {
                        if (!isEven(localRed))
                        {
                            pixel = Color.FromArgb(localRed + 1, pixel.G, pixel.B);
                            bitmapOfImage.SetPixel(0, j, pixel);
                        }
                        // Else leave as it is because there is no need to change the value
                        // as it is already one
                    }
                    else
                    {
                        pixel = Color.FromArgb(localRed - 1, pixel.G, pixel.B);
                        bitmapOfImage.SetPixel(0, j, pixel);
                    }
                }

                // Embed this pattern : 0000 (Four 0's)
                for (int j = 20; j < 24; j++)
                {
                    pixel = bitmapOfImage.GetPixel(0, j);
                    localRed = pixel.R;
                    if (localRed != 255)
                    {
                        if (isEven(localRed))
                        {
                            pixel = Color.FromArgb(localRed + 1, pixel.G, pixel.B);
                            bitmapOfImage.SetPixel(0, j, pixel);
                        }
                        // Else leave as it is because there is no need to change the value
                        // as it is already zero
                    }
                    // Else leave as it is as 255 is already odd
                }
            }

            // Encode the string passed
            string encodedText = fixedLengthEncoding(rawText);

            // Convert the image passed, to bitmap
            Bitmap bitmap = new Bitmap(rawImage);

            // Encode the pattern to infect the image xD
            encodeDelimiterPattern(bitmap);

            bool isNextCharacterOne = false;
            bool isRedPixelValueEven = false;

            byte red = 0;
            Color pixelAtLocation = new Color();

            for (int j = 0; j < 16; j++)
            {
                pixelAtLocation = bitmap.GetPixel(1, j);
                red = pixelAtLocation.R;
                isRedPixelValueEven = isEven(red);
                isNextCharacterOne = isOne(encodedText[j]);

                if ((!isNextCharacterOne && isRedPixelValueEven) || (isNextCharacterOne && !isRedPixelValueEven))
                {
                    if (red == 255)
                    {
                        pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                        bitmap.SetPixel(1, j, pixelAtLocation);
                    }
                    else
                    {
                        pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                        bitmap.SetPixel(1, j, pixelAtLocation);
                    }
                    // Nothing to worry about, already encoded
                }
                else
                {
                    //if (red == 255)
                    //{
                    //    pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                    //    bitmap.SetPixel(1, j, pixelAtLocation);
                    //}
                    //else
                    //{
                    //    pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                    //    bitmap.SetPixel(1, j, pixelAtLocation);
                    //}
                }
            }

            for (int j = 16; j < 32; j++)
            {
                pixelAtLocation = bitmap.GetPixel(2, j - 16);
                red = pixelAtLocation.R;
                isRedPixelValueEven = isEven(red);
                isNextCharacterOne = isOne(encodedText[j]);

                if ((!isNextCharacterOne && isRedPixelValueEven) || (isNextCharacterOne && !isRedPixelValueEven))
                {
                    // Nothing to worry about, already encoded
                    if (red == 255)
                    {
                        pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                        bitmap.SetPixel(2, j - 16, pixelAtLocation);
                    }
                    else
                    {
                        pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                        bitmap.SetPixel(2, j - 16, pixelAtLocation);
                    }
                }
                else
                {
                    //if (red == 255)
                    //{
                    //    pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                    //    bitmap.SetPixel(2, j - 16, pixelAtLocation);
                    //}
                    //else
                    //{
                    //    pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                    //    bitmap.SetPixel(2, j - 16, pixelAtLocation);
                    //}
                }
            }

            // Length of each character
            int x = Convert.ToInt32(encodedText.Substring(0, 16), 2);

            // Total no of characters encoded
            int y = Convert.ToInt32(encodedText.Substring(16, 16), 2);

            int totalCharacters = encodedText.Length;
            int lastEncodedCharacterIndex = 31 + 1;
            // Plus 1 is done for next iteration of loop

            // Row # 0, 1, 2 have already been used
            int currentRowNumber = 3;

            for (int i = 0; i < y; i++) // Loop no of times of characters encoded
            {
                for (int j = 0; j < x; j++) // Loop no of times of length of each character
                {
                    pixelAtLocation = bitmap.GetPixel(currentRowNumber, j);
                    red = pixelAtLocation.R;
                    isRedPixelValueEven = isEven(red);
                    isNextCharacterOne = isOne(encodedText[lastEncodedCharacterIndex]);

                    if ((!isNextCharacterOne && isRedPixelValueEven) || (isNextCharacterOne && !isRedPixelValueEven))
                    {
                        // Nothing to worry about, already encoded
                        if (red == 255)
                        {
                            pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                            bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        }
                        else
                        {
                            pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                            bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        }
                    }
                    else
                    {
                        //if (red == 255)
                        //{
                        //    pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                        //    bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        //}
                        //else
                        //{
                        //    pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                        //    bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        //}
                    }
                    lastEncodedCharacterIndex++;
                }

                currentRowNumber++;

                for (int j = 0; j < 8; j++) // Loop no of times of length of each character
                {
                    pixelAtLocation = bitmap.GetPixel(currentRowNumber, j);
                    red = pixelAtLocation.R;
                    isRedPixelValueEven = isEven(red);
                    isNextCharacterOne = isOne(encodedText[lastEncodedCharacterIndex]);

                    if ((!isNextCharacterOne && isRedPixelValueEven) || (isNextCharacterOne && !isRedPixelValueEven))
                    {
                        // Nothing to worry about, already encoded
                        if (red == 255)
                        {
                            pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                            bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        }
                        else
                        {
                            pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                            bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        }
                    }
                    else
                    {
                        //    if (red == 255)
                        //    {
                        //        pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                        //        bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        //    }
                        //    else
                        //    {
                        //        pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                        //        bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        //    }
                    }
                    lastEncodedCharacterIndex++;
                }

                currentRowNumber++;
            }

            int remainingCharacters = totalCharacters - lastEncodedCharacterIndex;

            string remainingCharactersInBinary = Convert.ToString(remainingCharacters, 2);
            remainingCharactersInBinary = remainingCharactersInBinary.PadLeft(16, '0');

            for (int j = 0; j < 16; j++)
            {
                if (remainingCharacters == 0)
                {
                    break;
                }
                else
                {
                    pixelAtLocation = bitmap.GetPixel(currentRowNumber, j);
                    red = pixelAtLocation.R;
                    isRedPixelValueEven = isEven(red);
                    isNextCharacterOne = isOne(remainingCharactersInBinary[j]);

                    if ((!isNextCharacterOne && isRedPixelValueEven) || (isNextCharacterOne && !isRedPixelValueEven))
                    {
                        // Nothing to worry about, already encoded
                        if (red == 255)
                        {
                            pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                            bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        }
                        else
                        {
                            pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                            bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        }
                    }
                    else
                    {
                        //if (red == 255)
                        //{
                        //    pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                        //    bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        //}
                        //else
                        //{
                        //    pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                        //    bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                        //}
                    }
                }
            }
            currentRowNumber++;

            while (lastEncodedCharacterIndex != totalCharacters)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(lastEncodedCharacterIndex == totalCharacters)
                    {
                        break;
                    }
                    else
                    {
                        pixelAtLocation = bitmap.GetPixel(currentRowNumber, j);
                        red = pixelAtLocation.R;
                        isRedPixelValueEven = isEven(red);
                        isNextCharacterOne = isOne(encodedText[lastEncodedCharacterIndex]);

                        if ((!isNextCharacterOne && isRedPixelValueEven) || (isNextCharacterOne && !isRedPixelValueEven))
                        {
                            // Nothing to worry about, already encoded
                            if (red == 255)
                            {
                                pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                                bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                            }
                            else
                            {
                                pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                                bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                            }
                        }
                        else
                        {
                            //if (red == 255)
                            //{
                            //    pixelAtLocation = Color.FromArgb(red - 1, pixelAtLocation.G, pixelAtLocation.B);
                            //    bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                            //}
                            //else
                            //{
                            //    pixelAtLocation = Color.FromArgb(red + 1, pixelAtLocation.G, pixelAtLocation.B);
                            //    bitmap.SetPixel(currentRowNumber, j, pixelAtLocation);
                            //}
                        }
                    }
                    lastEncodedCharacterIndex++;
                }
                currentRowNumber++;
            }

            return bitmap;
        }

        public static bool isImageInfected(Image rawImage)
        {
            // Checking for infected image
            Bitmap bitmap = new Bitmap(rawImage);

            for (int j = 0; j < 8; j++)
            {
                if (!isEven(bitmap.GetPixel(0, j).R))
                    return false;
            }
            for (int j = 8; j < 16; j++)
            {
                if (isEven(bitmap.GetPixel(0, j).R))
                    return false;
            }
            for (int j = 16; j < 20; j++)
            {
                if (!isEven(bitmap.GetPixel(0, j).R))
                    return false;
            }
            for (int j = 20; j < 24; j++)
            {
                if (isEven(bitmap.GetPixel(0, j).R))
                    return false;
            }

            return true;
        }

        public static string DeSteganoImage(Image rawImage)
        {
            string textToDecode = string.Empty;

            // Convert the image passed, to bitmap
            Bitmap bitmap = new Bitmap(rawImage);

            byte red = 0;

            for (int j = 0; j < 16; j++)
            {
                red = bitmap.GetPixel(1, j).R;
                textToDecode += (isEven(red)) ? '1' : '0';
            }
            for (int j = 16; j < 32; j++)
            {
                red = bitmap.GetPixel(2, j - 16).R;
                textToDecode += (isEven(red)) ? '1' : '0';
            }

            // Length of each character
            int x = Convert.ToInt32(textToDecode.Substring(0, 16), 2);

            // Total no of characters encoded
            int y = Convert.ToInt32(textToDecode.Substring(16, 16), 2);

            // Row # 0, 1, 2 have already been used
            int currentRowNumber = 3;

            for (int i = 0; i < y; i++) // Loop no of times of characters encoded
            {
                for (int j = 0; j < x; j++) // Loop no of times of length of each character
                {
                    red = bitmap.GetPixel(currentRowNumber, j).R;
                    textToDecode += (isEven(red)) ? '1' : '0';
                }
                currentRowNumber++;

                for (int j = 0; j < 8; j++) // Loop no of times of length of each character
                {

                    red = bitmap.GetPixel(currentRowNumber, j).R;
                    textToDecode += (isEven(red)) ? '1' : '0';
                }
                currentRowNumber++;
            }

            string remainingCharactersInString = string.Empty;

            for (int j = 0; j < 16; j++)
            {
                red = bitmap.GetPixel(currentRowNumber, j).R;
                remainingCharactersInString += (isEven(red)) ? '1' : '0';
            }
            currentRowNumber++;

            int remainingCharacters = Convert.ToInt32(remainingCharactersInString, 2);

            while (remainingCharacters > 0)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (remainingCharacters == 0)
                    {
                        break;
                    }
                    else
                    {
                        red = bitmap.GetPixel(currentRowNumber, j).R;
                        textToDecode += (isEven(red)) ? '1' : '0';
                    }
                    remainingCharacters--;
                }
                currentRowNumber++;
            }

            return fixedLengthDecoding(textToDecode);
        }
    }
}