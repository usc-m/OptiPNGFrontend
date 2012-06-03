# OptiPNGFrontend

## About

This is a simple frontend for OptiPNG (http://optipng.sourceforge.net/). 
Could not the command line version to accept unicode paths under Windows, so building a frontend was the obvious solution. 
Adds the ability to run multiple worker instances of OptiPNG, and create a queue of input files.
These features are acheived by creating a temporary directory and placing renamed copies of the input files inside.
The resulting output is then transferred back to the source directory (or a specified output directory) and the temporary files tidied up.

## Requirements

OptiPNG binaries are not included. Prebuilt binaries and source can be found here from http://optipng.sourceforge.net/
This code was built to function with OptiPNG 0.7.1.

## License

The source code of this program is licensed under the MIT License