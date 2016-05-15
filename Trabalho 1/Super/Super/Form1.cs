using System;
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
        private SuperStock superStock;
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

            zone = (IZone)Activator.GetObject(typeof(IZone), string.Format("{0}/{1}", string.Format(url, port), "zone.soap"));
            stockManager = new StockManager();
            superStock = new SuperStock();

            zone.Register(stockManager, superStock.Stock);

            MessageBox.Show(string.Format("Super registado na zona {0}", port),
                "Super registado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
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

            zone.Unregister(stockManager);
        }

        private void buttonFindStock_Click(object sender, EventArgs e)
        {
            IEnumerable<Item> localStock;
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

            localStock = zone.GetItemStock(itemToSearch);

            if (localStock != null)
            {
                listViewStock.Items[0].SubItems.AddRange(localStock.Select(s => s.SuperID.ToString()).ToArray());
                listViewStock.Items[1].SubItems.AddRange(localStock.Select(s => s.Name).ToArray());
                listViewStock.Items[2].SubItems.AddRange(localStock.Select(s => s.Qtd.ToString()).ToArray());
            }
            else
            {
                MessageBox.Show("Não existe stock disponivel para esse produto",
                "Stock inexistente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return;
            }
        }
    }
}
