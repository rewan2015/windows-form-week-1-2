using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkspaceManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menuStrip = new MenuStrip();
            this.toolStrip = new ToolStrip();
            this.mainPanel = new Panel();
            this.sidePanel = new Panel();
            this.quickInfoLabel = new Label();

            // Main Menu
            ToolStripMenuItem usersMenuItem = new ToolStripMenuItem("User Management");
            ToolStripMenuItem bookingMenuItem = new ToolStripMenuItem("Desk Booking");
            ToolStripMenuItem reportsMenuItem = new ToolStripMenuItem("Reports");
            ToolStripMenuItem settingsMenuItem = new ToolStripMenuItem("Settings");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit", null, ExitApplication);

            menuStrip.Items.AddRange(new ToolStripItem[] { usersMenuItem, bookingMenuItem, reportsMenuItem, settingsMenuItem, exitMenuItem });
            menuStrip.BackColor = Color.FromArgb(45, 45, 48);
            menuStrip.ForeColor = Color.White;
            menuStrip.Font = new Font("Arial", 10, FontStyle.Bold);

            // Tool Strip
            ToolStripButton addButton = new ToolStripButton("Add User");
            ToolStripButton searchButton = new ToolStripButton("Search");
            toolStrip.Items.AddRange(new ToolStripItem[] { addButton, searchButton });
            toolStrip.BackColor = Color.FromArgb(60, 60, 65);
            toolStrip.ForeColor = Color.White;

            // Side Panel - Quick Info
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 250;
            sidePanel.BackColor = Color.FromArgb(30, 30, 35);

            quickInfoLabel.Text = "Quick Info Panel" + "\n" + "Current Bookings: 10" + "\n" + "Available Spaces: 5";
            quickInfoLabel.AutoSize = true;
            quickInfoLabel.ForeColor = Color.White;
            quickInfoLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            quickInfoLabel.Location = new System.Drawing.Point(10, 10);
            sidePanel.Controls.Add(quickInfoLabel);

            // Main Panel
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Color.FromArgb(50, 50, 55);

            // Form Properties
            this.Controls.Add(mainPanel);
            this.Controls.Add(sidePanel);
            this.Controls.Add(toolStrip);
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;
            this.Text = "Workspace Management System";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(40, 40, 45);
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private Panel mainPanel;
        private Panel sidePanel;
        private Label quickInfoLabel;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
