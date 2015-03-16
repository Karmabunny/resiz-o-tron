#!/bin/bash

cd `pwd`
mkdir resiz-o-tron-$1
cp README.md resiz-o-tron-$1
cp LICENSE resiz-o-tron-$1
cp bin/Release/ResizOTron.exe resiz-o-tron-$1
zip -9 -r resiz-o-tron-$1.zip resiz-o-tron-$1
tar -cjf resiz-o-tron-$1.tar.bz2 resiz-o-tron-$1
rm -rf resiz-o-tron-$1
