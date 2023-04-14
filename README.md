### LockBox

LockBox is a simple encryption and decryption program for file safety. It uses the AES encryption algorithm to encrypt and decrypt files. 

## Requirements

- .NET Framework 4.8 or later

## Usage

- Encrypt a file:

LockBox.exe --Encrypt InputFilePath OutputFile EncryptionKey

- `InputFilePath` - the path of the file to be encrypted
- `OutputFile` - the name and path of the encrypted output file
- `EncryptionKey` - the key to be used for encryption

- Decrypt a file:

LockBox.exe --Decrypt InputFilePath OutputFile EncryptionKey

- `InputFilePath` - the path of the file to be decrypted
- `OutputFile` - the name and path of the decrypted output file
- `EncryptionKey` - the key to be used for decryption

## Example

Encrypting a file:

LockBox.exe --Encrypt C:\Users\JohnDoe\Documents\file.txt C:\Users\JohnDoe\Documents\file.(any_extension) mySecretKey123

Decrypting a file:

LockBox.exe --Decrypt C:\Users\JohnDoe\Documents\file.lockbox C:\Users\JohnDoe\Documents\file.(any_extension) mySecretKey123

## License

This project is licensed under the MIT License - see the LICENSE file for details.
