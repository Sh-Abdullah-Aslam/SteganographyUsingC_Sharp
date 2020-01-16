# Steganography using C#
A simple c# windows form application to hide text in images.

## 1.0 Methodology to encode text into an image
```
1.1 Select an image
1.2 Write text to hide into the image
1.3 Save the image with encoded text, onto the disk
```

## 2.0 Methodology to decode text from an image
```
2.1 Select an image
2.2 Press decode button to retrieve encoded text.
  " Note: If image was not priorly encoded, an error message will display. "
2.3 Copy the decoded text to clipboard and enjoy.
```

## 3.0 Technique to encode text using Fixed-Length Huffman encoding 
```
3.1 First 16 bits of the string will specify the length of each encoded character
3.2 Next 16 bits of the string will specify the total number of characters encoded
3.3 Then use n number of bits to save the encoding of character (n will depend on 3.1)
3.4 Save the 8 bits ascii value next to the encoded character
3.5 Atlast save the encoded message
```

## 4.0 Decode the text by repeating the above process in reverse order


## 5.0 How to hide the text into images
```
#### Note : This technique only uses the red channel of the image
5.1 Read an image from the disk and convert it into a Bitmap
5.2 Store this pattern 1111 1111 0000 0000 1111 0000 the first row of pixels to indicate an encoded image
5.3 In the next row, store the length of each encoded charater (16 bits)
5.4 In the following row, store the number of characters encoded (16 bits)
5.5 Store the code of a charater in the next row
5.6 Store the 8 bits ascii value of charater in the next row
5.7 Repeat 5.5 and 5.6 till all the characters' codes have been saved
5.8 To encode the message, use first 8 pixels of each row until all the message has been encoded
```

## 6.0 How to retrieve hidden text from images
```
6.1 Read an image from the disk and convert it into a Bitmap
6.2 Check for the pattern 1111 1111 0000 0000 1111 0000 in the first row of pixels
6.3 If the above pattern is matched then jump to 6.5
6.4 Display an error that image is not infected and stop
6.5 Start retriving the encoded text by repeating the same procedure in "5.1 to 5.8". However, instead of encoding the information now retrieve the information only.
6.6 Apply the Huffman-Decoding to the data retrieved to get the encoded message
```

# Cite me if you want to reuse this application(both with or without modification).
# Enjoy programming :-)
