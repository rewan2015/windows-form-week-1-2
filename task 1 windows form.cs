// Main Form UI Design using C# and Windows Forms
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookingSystemUI
{
    public class MainForm : Form
    {
        private Panel sidebar;
        private Panel dashboard;
        private Label lblHeader;
        private Panel card1, card2, card3;

        // Define UI colors as variables
        private readonly Color bgColor = Color.FromArgb(245, 247, 250);         // #F5F7FA
        private readonly Color sidebarColor = Color.FromArgb(46, 58, 89);       // #2E3A59
        private readonly Color accentColor = Color.FromArgb(37, 99, 235);       // #2563EB

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Main form settings
            this.Text = "Main Form";
            this.Size = new Size(1000, 600);
            this.BackColor = bgColor;
            this.Font = new Font("Segoe UI", 10);

            // Sidebar setup
            sidebar = new Panel();
            sidebar.BackColor = sidebarColor;
            sidebar.Size = new Size(220, this.Height);
            sidebar.Dock = DockStyle.Left;
            this.Controls.Add(sidebar);

            // Sidebar items
            string[] items = {
                "Dashboard",
                "Booking Management",
                "Clients",
                "Reports",
                "Settings",
                "Login",
                "Advanced Search",
                "Export"
            };

            for (int i = 0; i < items.Length; i++)
            {
                Button btn = new Button();
                btn.Text = items[i];
                btn.Dock = DockStyle.Top;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.White;
                btn.BackColor = sidebarColor;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                sidebar.Controls.Add(btn);
                sidebar.Controls.SetChildIndex(btn, 0);
            }

            // Header label
            lblHeader = new Label();
            lblHeader.Text = "Dashboard";
            lblHeader.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblHeader.Location = new Point(250, 20);
            lblHeader.AutoSize = true;
            this.Controls.Add(lblHeader);

            // Dashboard panel
            dashboard = new Panel();
            dashboard.Location = new Point(250, 70);
            dashboard.Size = new Size(700, 200);
            dashboard.BackColor = Color.Transparent;
            this.Controls.Add(dashboard);

            // Dashboard cards
            card1 = CreateCard("Total Bookings", "150", 0);
            card2 = CreateCard("Available Spaces", "12", 1);
            card3 = CreateCard("New Clients Today", "5", 2);
            dashboard.Controls.AddRange(new Control[] { card1, card2, card3 });
        }

        private Panel CreateCard(string title, string value, int index)
        {
            Panel card = new Panel();
            card.Size = new Size(200, 120);
            card.Location = new Point(index * 220, 0);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;

            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblValue.ForeColor = accentColor;
            lblValue.Location = new Point(10, 50);
            lblValue.AutoSize = true;

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

