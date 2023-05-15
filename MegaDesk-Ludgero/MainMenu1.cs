using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ludgero
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteForm = new AddQuote();
            viewAddQuoteForm.Tag = this;
            viewAddQuoteForm.Show(this);
            Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewAllQuotes = new ViewAllQuotes();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
            Hide();

        }
        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotesFrom = new SearchQuotes();
            viewSearchQuotesFrom.Tag = this;
            viewSearchQuotesFrom.Show(this);
            Hide();
        }       

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
