namespace ContactFormatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string emailAddress = txtEmailAddress.Text.Trim();
            string username = "";
            string domain = "";
            string[] strings;

            if (!emailAddress.Contains("@"))
            {
                MessageBox.Show("Must be a valid email address", "Error");
            }
            else
            {
                strings = emailAddress.Split('@');

                MessageBox.Show("Username: " + strings[0] +
                    "\n" + "Domain: " + strings[1], "Parse Email Address");
            }

            /*
            int index = emailAddress.IndexOf("@");

            if (index == -1)
            {
                MessageBox.Show("Must be a valid email address", "Error");
            } else
            {
                username = emailAddress.Substring(0, index);
                domain = emailAddress.Substring(index + 1);

                MessageBox.Show("Username: " + username +
                    "\n" + "Domain: " + domain, "Parse Email Address");
            }
            */
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim().ToUpper();
            string zip = txtZip.Text.Trim();

            if(city.Length == 0)
            {
                MessageBox.Show("City cannot be empty", "Error");
            } else
            {
                
                char upperCityChar = char.ToUpper(city[0]);
                city = city.Remove(0,1);
                city = city.Insert(0, upperCityChar.ToString());
            }
            
            if (zip.Length != 5)
            {
                MessageBox.Show("ZIP code must be five digits", "Error");
            } else if(state.Length != 2)
            {
                MessageBox.Show("State must be two letter abbreviation", "Error");
            }
            else
            {
                MessageBox.Show("Address: " + city + " " + state +
                    " " + zip, "Formatted Address");
            }
        }
    }
}