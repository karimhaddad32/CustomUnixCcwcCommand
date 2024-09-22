**ccwc: A Simple Word Count Tool**

**Purpose:**

This project aims to create a basic word count tool, `ccwc`, that can count the number of characters, lines, and words in a given file or standard input.

**Features:**

Supports command-line options:
- `-c`: Counts the number of bytes.
- `-l`: Counts the number of lines.
- `-w`: Counts the number of words.
- `-m`: Counts the number of characters (equivalent to -c if the locale doesn't support multibyte characters).
- Counts the number of lines, words, and bytes if no option was specified. 
- Reads from standard input if no filename is specified, starting with the command `cat` followed by the text input

Usage:

`ccwc [options] [filename]`

Examples for this [text file](https://github.com/karimhaddad32/CustomUnixCcwcCommand/blob/master/test.txt):

**input**: `ccwc -c test.txt` 
**output**: `342190 test.txt`

**input**: `ccwc -l test.txt` 
**output**: `7145 test.txt`

**input**: `ccwc -w test.txt` 
**output**: `58164 test.txt`

**input**: `ccwc -m test.txt` 
**output**: `339291 test.txt`

**input**: `ccwc test.txt` 
**output**: `7145   58164  342190 test.txt`

**input**: `cat standard.txt | ccwc -l` 
**input**: `Enter text: Hello World` 
**output**: `1  2  14 standard.txt`
