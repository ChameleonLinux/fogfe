#-------------------------------------------------
#
# Project created by QtCreator 2016-07-17T07:39:41
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = FogFileEditor
TEMPLATE = app

CONFIG += c++14

SOURCES += main.cpp\
        mainwindow.cpp

HEADERS  += mainwindow.h

FORMS    += mainwindow.ui

win32:CONFIG(release, debug|release): LIBS += -L$$PWD/../../CPP/build-FogHandler-Desktop_Qt_5_7_0_MinGW_32bit-Debug/release/ -lFogHandler
else:win32:CONFIG(debug, debug|release): LIBS += -L$$PWD/../../CPP/build-FogHandler-Desktop_Qt_5_7_0_MinGW_32bit-Debug/debug/ -lFogHandler
else:unix: LIBS += -L$$PWD/../../CPP/build-FogHandler-Desktop_Qt_5_7_0_MinGW_32bit-Debug/ -lFogHandler

INCLUDEPATH += $$PWD/../../CPP/FogHandler
DEPENDPATH += $$PWD/../../CPP/FogHandler

DISTFILES += \
    README.md \
    LICENSE.md
