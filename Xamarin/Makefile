
XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=../ZipArchive
PROJECT=$(PROJECT_ROOT)/ZipArchive.xcodeproj/
TARGET=ZipArchive

all : ZipArchiveLibrary/lib$(TARGET).a

ZipArchiveLibrary/lib$(TARGET)-i386.a :
	mkdir -p ZipArchiveLibrary
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET)-ios.a $@

ZipArchiveLibrary/lib$(TARGET)-armv7.a :
	mkdir -p ZipArchiveLibrary
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET)-ios.a $@

ZipArchiveLibrary/lib$(TARGET)-armv7s.a :
	mkdir -p ZipArchiveLibrary
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET)-ios.a $@

ZipArchiveLibrary/lib$(TARGET)-arm64.a : 
	mkdir -p ZipArchiveLibrary
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET)-ios.a $@


ZipArchiveLibrary/lib$(TARGET).a : ZipArchiveLibrary/lib$(TARGET)-i386.a ZipArchiveLibrary/lib$(TARGET)-armv7.a ZipArchiveLibrary/lib$(TARGET)-armv7s.a ZipArchiveLibrary/lib$(TARGET)-arm64.a
	lipo -create -output $@ $^

clean : 
	rm -rf ZipArchiveLibrary

