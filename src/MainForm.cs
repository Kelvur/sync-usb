
using System;
using System.Windows.Forms;

namespace SyncUsb {
	
	public class MainForm : Form {
	
		private static string TEXT_TITLE = "SyncUsb";
		private static string TEXT_BUTTON_SYNC_TO_USB = "Carpeta -> USB";
		private static string TEXT_BUTTON_SYNC_TO_FOLDER = "USB -> Carpeta";
		private static bool SHOW_MAXIMIZE = false;
		private static bool SHOW_MINIMIZE = true;
		
		private NotifyIcon notifyIcon;
		private Button buttonSyncToUsb;
		private Button buttonSyncToFolder;
		
		public MainForm(){
			init();
		}
		
		private void init(){
			initMainForm();
			initNotifyIcon();
			initButtonSyncToUsb();
			initButtonSyncToFolder();
		}
		
		private void initMainForm(){
			this.Text = TEXT_TITLE;
			this.MaximizeBox = SHOW_MAXIMIZE;
			this.MinimizeBox = SHOW_MINIMIZE;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.Resize += new EventHandler(MainForm_Resize);
		}
		
		private void initNotifyIcon(){
			notifyIcon = new NotifyIcon();
			notifyIcon.Icon = new System.Drawing.Icon("icon.ico");
			notifyIcon.DoubleClick += new EventHandler(NotifyIcon_DoubleClick);
		}
		
		private void initButtonSyncToUsb(){
			buttonSyncToUsb = new Button();
			buttonSyncToUsb.Text = TEXT_BUTTON_SYNC_TO_USB;
			buttonSyncToUsb.Top = 30;
			buttonSyncToUsb.Left = 30;
			buttonSyncToUsb.Click += new EventHandler(ButtonSyncToUsb_Click);
			this.Controls.Add(buttonSyncToUsb);
		}
		
		private void initButtonSyncToFolder(){
			buttonSyncToFolder = new Button();
			buttonSyncToFolder.Text = TEXT_BUTTON_SYNC_TO_FOLDER;
			buttonSyncToFolder.Click += new EventHandler(ButtonSyncToFolder_Click);
			this.Controls.Add(buttonSyncToFolder);
		}
		
		////////////////////// EVENTS //////////////////////
		
		private void MainForm_Resize(object sender, EventArgs eventArgs){
			if(this.WindowState == FormWindowState.Minimized){
				this.WindowState = FormWindowState.Normal;
				notifyIcon.Visible = true;
				Hide();
			}
		}
		
		private void NotifyIcon_DoubleClick(object sender, EventArgs eventArgs){
			Show();
			notifyIcon.Visible = false;
		}
		
		private void ButtonSyncToUsb_Click(object sender, EventArgs eventArgs){
			Console.WriteLine("Copiar al Usb");
		}
		
		private void ButtonSyncToFolder_Click(object sender, EventArgs eventargs){
			Console.WriteLine("Copiar a la Carpeta");
		}
	
	}
	
}