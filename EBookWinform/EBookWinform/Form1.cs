using EbookWinform;
using EbookWinform.Models;

namespace EBookWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string country = textBox2.Text;
            string id = textBox3.Text;
            var db = new AppDbContext();
            //var author = db.Authors.ToList();

            Authors author1 = new Authors();
            author1.ID = id;
            author1.AName = name;
            author1.Country = country;
            if (InAuthorIDexist(author1.ID, db))
            {
                MessageBox.Show("Ban da nhap trung ID" + author1.ID);
                return;
            }
            db.Authors.Add(author1);
            db.SaveChanges();
            //label3.Text = "Ban da nhap thanh cong";
            MessageBox.Show("Ban da nhap thanh cong");
        }
        private bool InAuthorIDexist(string id, AppDbContext db)
        {
            var authors = db.Authors.ToList();
            foreach (var at in authors)
            {
                if (at.ID == id) return true;
            }
            return false;
        }
    }
}
