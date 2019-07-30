# ImageCA

[![Build Status](https://travis-ci.com/CozyPenguin/ImageCA.svg?branch=master)](https://travis-ci.com/CozyPenguin/ImageCA) [![Nuget](https://img.shields.io/nuget/dt/ImageCA?color=d&label=Nuget)](https://www.nuget.org/packages/ImageCA)

## Introduction

ImageCA is a work in progress library used to analyze image databases and processing colors. It was originally developed for a contribution to the German project Lab2Venture (<https://www.l2v-berlin.de/>).

## Installation

Currently there are no prebuilt binaries. If you want to build the project from source, there's a guide for it in the [INSTALL.md](INSTALL.md).

## Features

**the project is not finished yet, this part describes the project when it's finished!**

ImageCA provides a way to analyse one or several images. It is capable of extracting a colour from one or several points in the image. These colours can be processed separately or be combined into a single color, e.g. to get the average color of a probe. The library also provides vectors and in the future, ImageCA will be capable of performing several render-oriented operations. Additionally there will be other colorspaces and better conversion support. 

## Roadmap

After we've finished the vectors, we will focus on prebuilt binaries and a nuget package. Our roadmap is:

version | roadmap
------- | -------
`version 0.3` | add CIELUV and CIELAB colorspace and all conversion algorithms
`version 0.4` | better image loading and processing, support for multiple images

## Credits

All contributors can be found in the [CONTRIBUTORS.md](CONTRIBUTORS.md). 

## Resources

RGB to HSV conversion algorithm:

- <https://en.wikipedia.org/wiki/HSL_and_HSV#From_RGB>
- <https://www5.in.tum.de/lehre/vorlesungen/graphik/info/csc/COL_25.htm#topic24>

## License

The project is licensed under the [MIT-License](LICENSE).
