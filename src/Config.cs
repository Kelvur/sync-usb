
using System;
using System.Runtime.Serialization;

namespace SyncUsb {
	
	[Serializable]
	public class Config : ISerializable {
		
		private static string FILE_CONFIG = "config.cfg";
		private string sourcePath = null;
		private string usbPath = null;
		private string usbHash = null;
		
		public Config(){
		}
		
		// ====== GETTER ======
		public string getSourcePath(){
			return sourcePath;
		}
		public string getUsbPath(){
			return usbPath;
		}
		public string getUsbHash(){
			return usbHash;
		}
		
		// ====== SETTER ======
		public void setSourcePath(string sourcePath){
			this.sourcePath = sourcePath;
		}
		public void setUsbPath(string usbPath){
			this.usbPath = usbPath;
		}
		public void setUsbHash(string usbHash){
			this.usbHash = usbHash;
		}
		
		// Serialize
		public void GetObjectData(SerializationInfo info, StreamingContext context){
			info.AddValue("sourcePath", sourcePath, typeof(string));
			info.AddValue("usbPath", usbPath, typeof(string));
			info.AddValue("usbHash", usbHash, typeof(string));
		}
		
		// Deserialize
		public Config(SerializationInfo info, StreamingContext context){
			sourcePath = (string) info.GetValue("sourcePath", typeof(string));
			usbPath = (string) info.GetValue("usbPath", typeof(string));
			usbHash = (string) info.GetValue("usbHash", typeof(string));
		}
		
		public override string ToString(){
			return String.Format("{0}\n-Source Path: {1}\n-Usb Path: {2}\n-Usb Hash: {3}", 
					this.GetType().FullName, 
					sourcePath, 
					usbPath, 
					usbHash);
		}
		
	}
	
}