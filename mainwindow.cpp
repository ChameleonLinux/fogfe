#include "mainwindow.h"
#include "ui_mainwindow.h"

#include <QDebug>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    this->parser = new Fog();

    connect(ui->actionOpen, &QAction::triggered, this, &MainWindow::loadFog);
}

void MainWindow::loadFog() {
    QString fog = QFileDialog::getOpenFileName(this, "Choose file to open", QString(), "*.fog");
    if(fog != nullptr) {
        this->currfname = fog;
        this->fog = this->parser->read(fog.toUtf8().constData());
        int ind = 0;
        ui->table_super->setRowCount(this->fog->super->entries.size());
        for (Entry_SUPER* entry : this->fog->super->entries)
        {
            ui->table_super->setItem(ind, 0, new QTableWidgetItem(QString::fromStdString(entry->key)));
            ui->table_super->setItem(ind, 1, new QTableWidgetItem(QString::fromStdString(entry->value)));
            ind++;
        }
        ui->table_data->setRowCount(this->fog->data->entries.size());
        ind = 0;
        for (Entry_DATA* entry : this->fog->data->entries)
        {
            ui->table_data->setItem(ind, 0, new QTableWidgetItem(QString::fromStdString(entry->id)));
            ui->table_data->setItem(ind, 1, new QTableWidgetItem(QString::fromStdString(entry->dest)));
            ui->table_data->setItem(ind, 2, new QTableWidgetItem(QString::fromStdString(entry->type)));
            ui->table_data->setItem(ind, 3, new QTableWidgetItem(QString::fromStdString(entry->fname)));
            ind++;
        }
    }
}

MainWindow::~MainWindow()
{
    delete ui;
}
