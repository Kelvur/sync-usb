
using Microsoft.VisualBasic.FileIO;

namespace SyncUsb {
	
	public class CopyProgress {
		
		public static void Copy(Config config){
			FileSystem.CopyDirectory(config.getSourcePath(), config.getUsbPath(), UIOption.AllDialogs);
		}
		
	}
	
}
