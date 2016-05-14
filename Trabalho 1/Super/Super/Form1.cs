﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISuper;
using System.Configuration;
using ISuperInterfaces;

namespace Super
{
    public partial class SuperGI : Form
    {
        private IStockManager stockManager;
        private IZone zone;
        private Stock stock;
        private string _url;
        public string url
        {
            get
            {
                if (_url == null)
                {
                    if (ConfigurationManager.AppSettings["url"] == null)
                    {
                        throw new ArgumentNullException("Key url not present in App.config");
                    }
                    _url = ConfigurationManager.AppSettings["url"];
                }
                return _url;
            }
        }
        public SuperGI()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string port = textBoxPort.Text;

            if (port == null)
            {
                MessageBox.Show("É necessário preencher o campo porta da zona",
                "Campo da porta vazio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            zone = (IZone)Activator.GetObject(typeof(IZone), string.Format("{0}", string.Format(url, port), "/zone"));
            stockManager = (IStockManager)Activator.GetObject(typeof(IStockManager), string.Format("{0}", string.Format(url, port), "/stockmanger"));
            stock = new Stock();

            zone.Register(stockManager, stock.Items);
        }

        private void buttonUnregister_Click(object sender, EventArgs e)
        {
            if (zone == null)
            {
                MessageBox.Show("É necessário estar registado numa zona",
                "Cancelamento falhado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            zone.Unregister();
        }

        private void buttonFindStock_Click(object sender, EventArgs e)
        {
            IEnumerable<Item> localStock;
            IEnumerable<Item> remoteStock;
            string itemToSearch = textBoxItem.Text;

            if (itemToSearch == null)
            {
                MessageBox.Show("É necessário preencher o campo do produto a procurar",
                "Campo do produto vazio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            localStock = stockManager.GetLocalStock(itemToSearch);
            remoteStock = stockManager.GetRemoteStock(itemToSearch);

            //Insert stock in listView
        }
    }
}
