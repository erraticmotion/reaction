namespace System.Usb
{
    using IO;

    using Microsoft.SPOT.IO;
    
    using GHIElectronics.NETMF.IO;
    using GHIElectronics.NETMF.USBHost;

    public sealed class UsbDrive 
    {
        private bool driveMounted;
        private PersistentStorage persistantStorage;
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly UsbDrive Instance = new UsbDrive();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsbDrive"/> class.
        /// </summary>
        private UsbDrive()
        {
            RemovableMedia.Insert += RemovableMediaInsert;
            RemovableMedia.Eject += RemovableMediaEject;
        }

        public void Mount(USBH_Device device)
        {
            if (driveMounted)
            {
                return;
            }

            persistantStorage = new PersistentStorage(device);
            persistantStorage.MountFileSystem();
            driveMounted = true;
        }

        /// <summary>
        /// Occurs when a removable media has been inserted and is ready for use.
        /// </summary>
        public event MediaInsertedEventHandler MediaInserted;

        /// <summary>
        /// Occurs when a removable media has been ejected from the device.
        /// </summary>
        public event MediaEjectedEventHandler MediaEjected;

        private void RemovableMediaInsert(object sender, MediaEventArgs e)
        {
            if (driveMounted)
            {
                var ev = MediaInserted;
                if (ev != null)
                {
                    ev(this, new RemovableVolumeEventArgs(e.Volume));
                }
            }
        }

        private void RemovableMediaEject(object sender, MediaEventArgs e)
        {
            if (!driveMounted)
            {
                return;
            }

            driveMounted = false;
            var ev = MediaEjected;
            if (ev != null)
            {
                ev(this, new RemovableVolumeEventArgs(e.Volume));
            }
        }
    }
}
