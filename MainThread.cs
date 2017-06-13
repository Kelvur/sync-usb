
using System;
using System.Windows.Forms;
using SyncUsb;

class MainThread {
	
	public static void Main(string[] args){
		MainThread main = new MainThread();
		main.init();
	}
	
	public void init(){
		Config config = initConfig();
		initUsbListener(config);
		initUi();
	}
	
	public Config initConfig(){
		return new Config();
	}
	
	public void initUsbListener(Config config){
		UsbListener listener = new UsbListener(config.getUsbHash(), test);
		Thread thread = new Thread(new ThreadStart(listener.start));
		thread.Start();
	}
	
	public void initUi(){
		Application.EnableVisualStyles();
		Application.Run(new MainForm());
	}
	
	public void printAllUsb(){
		foreach(UsbStore usb in UsbStoreProvider.getAllUsbStore()){
			Console.WriteLine("\t- " + usb.getHash());
		}
	}
	
	public string test(){
		return "test";
	}

}
