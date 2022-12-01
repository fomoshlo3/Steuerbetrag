namespace USteuerbetrag
{

    public partial class Form1 : Form
    {
        const string OUTPUTTEXT = "Steuerbetrag";
        private decimal _Gehalt;

        public decimal Gehalt
        {
            get
            {
                return _Gehalt;
            }
            set
            {
                _Gehalt = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdCalculate1_Click(object sender, EventArgs e)
        {
            /* 0 bis 12.000 € >> 12%
             * 12.000 bis 20.000 € >> 15%
             * 20.000 bis 30.000 € >> 20%
             * über 30.000 € >> 25%
             */
            Gehalt = Decimal.Parse(TBxUserInput.Text);

            if (Gehalt > 30000m)
            {
                LblSteuerbetrag.Text = $"{OUTPUTTEXT}: {Gehalt * 0.25m:C2}";
            }
            else if (Gehalt <= 30000m && Gehalt > 20000m)
            {
                LblSteuerbetrag.Text = $"{OUTPUTTEXT}: {Gehalt * 0.2m:C2}";
            }
            else if (Gehalt <= 20000m && Gehalt > 12000m)
            {
                LblSteuerbetrag.Text = $"{OUTPUTTEXT}: {Gehalt * 0.15m:C2}";
            }
            else
            {
                LblSteuerbetrag.Text = $"{OUTPUTTEXT}: {Gehalt * 0.12m:C2}";
            }
        }

        private void CmdCalculate2_Click(object sender, EventArgs e)
        {
            Gehalt = Decimal.Parse(TBxUserInput.Text);
            LblSteuerbetrag.Text = "Steuerbetrag: " + Gehalt switch
            {
                <= 12000m => $"{Gehalt * 0.12m:C2}",
                <= 20000m => $"{Gehalt * 0.15m:C2}",
                <= 30000m => $"{Gehalt * 0.2m:C2}",
                _ => $"{Gehalt * 0.25m:C2}",
            };
        }

        private void CmdSteuertabelleAnzeigen_Click(object sender, EventArgs e)
        {
            //Form ChildForm = new();
            //ChildForm.ShowDialog();
            decimal steuersatz, steuerbetrag, netto;

            LblSteuerbetrag.Text = "Steuertabelle:\n";

            for (decimal gehalt = 5000m; gehalt <= 35000m; gehalt+= 3000m)
            {
                steuersatz = gehalt switch
                {
                    <= 12000m => 12m,
                    <= 20000m => 15m,
                    <= 30000m => 20m,
                            _ => 25m
                };
                steuerbetrag = steuersatz * gehalt / 100;
                netto = gehalt - steuerbetrag;
                LblSteuerbetrag.Text += $"  {gehalt,+1:C2} , {steuersatz}%, {steuerbetrag:C2}, {netto:C2}\n";
            }


        }
    }
}