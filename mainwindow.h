#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QFileDialog>
#include <parsedfile.h>
#include <entries.h>
#include <fog.h>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    QString currfname;
    ParsedFog* fog;
    ~MainWindow();

public slots:
    void loadFog();

private:
    Fog* parser;
    Ui::MainWindow *ui;
};

#endif // MAINWINDOW_H
