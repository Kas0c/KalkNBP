using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;

namespace KalkNBP
{
    public partial class Form1 : Form
    {
        private Dictionary<string, float> _rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GetRates(object sender, EventArgs e)
        {
            XDocument xml = XDocument.Load("http://api.nbp.pl/api/exchangerates/tables/a/?format=xml");
            //wybiera wszystkie elementy o tagu "Rate" z dokumentu xml
            var rates = xml.Descendants("Rate");
            //wyczyszcza s³ownik
            _rates.Clear();
            foreach (var rate in rates)
            {
                string code = rate.Element("Code").Value;
                float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);

                _rates.Add(code, mid);
            }
            //odbiera waluty z '_rates' i przekszta³ca je w string
            EURRate.Text = _rates["EUR"].ToString();
            USDRate.Text = _rates["USD"].ToString();
            JPYRate.Text = _rates["JPY"].ToString();
        }

        private void ExchangeBtn_Click(object sender, EventArgs e)
        {
            float pln = float.Parse(PLNAmount.Text);
            float exchanged = 0;
            //przekszta³ca podana wartoœæ w zale¿noœci od wybranego radioButton
            if (EURradioButton.Checked)
            {
                string rate = EURRate.Text;
                float mid = Convert.ToSingle(rate);
                exchanged = pln / mid;
            }
            if (USDradioButton.Checked)
            {
                string rate = USDRate.Text;
                float mid = Convert.ToSingle(rate);
                exchanged = pln / mid;
            }
            if (JPYradioButton.Checked)
            {
                string rate = JPYRate.Text;
                float mid = Convert.ToSingle(rate);
                exchanged = pln / mid;
            }
            //wynik jest zaokr¹glony
            exchanged = (float)Math.Round(exchanged, 2);
            Exchange.Text = exchanged.ToString();
        }
    }
}