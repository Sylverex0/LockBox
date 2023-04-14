# LockBox

LockBox is a console application that provides an easy way to encrypt and decrypt files using symmetric-key encryption algorithms.

## Features

- Supports encryption and decryption of files using a symmetric-key encryption algorithm.
- Provides customizable options for encryption, including algorithm selection and key size.
- Simple and easy-to-use command-line interface.

## Installation

1. Clone the LockBox repository to your local machine.
2. Open a command prompt or terminal window and navigate to the LockBox project directory.
3. Run `dotnet build` to build the project.
4. Run `dotnet run` to launch the application.

## Usage

To encrypt a file, run the following command:

- lockbox.exe encrypt <input-file> <output-file> <key> [--algorithm <algorithm>] [--keysize <keysize>]

## ? 
- `<input-file>`: The path to the file to be encrypted.
- `<output-file>`: The path to the encrypted output file.
- `<key>`: The encryption key to use.
- `--algorithm`: (Optional) The encryption algorithm to use (default is AES).
- `--keysize`: (Optional) The key size to use (default is 256 bits).

To decrypt a file, run the following command:

- `<input-file>`: The path to the encrypted file to be decrypted.
- `<output-file>`: The path to the decrypted output file.
- `<key>`: The decryption key to use.
- `--algorithm`: (Optional) The encryption algorithm to use (default is AES).
- `--keysize`: (Optional) The key size to use (default is 256 bits).

## Contributions

We welcome contributions to the LockBox project! To get started, please see our contribution guidelines in CONTRIBUTING.md.

## License

LockBox is released under the MIT license. Please see the LICENSE file for more information.

## Contact

If you have any questions or feedback about LockBox, please contact my discord at sylver#3544
