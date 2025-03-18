using LibUsbDotNet;
using LibUsbDotNet.Main;
using System;

class Program {
    static void Main(string[] args) {
        ListUsbDevices();
        MonitorPowerStatus();
    }

    static void ListUsbDevices() {
        try {
            // i'll probably need to find the actual ids but it keeps reconnecting annoyingly
            UsbDeviceFinder usbFinder = new UsbDeviceFinder(0x0000, 0x0000);
            UsbDevice device = UsbDevice.OpenUsbDevice(usbFinder);

            if (device != null) {
                Console.WriteLine("USB Device found:");
                Console.WriteLine($"Device {device.Info.ProductString}");
                Console.WriteLine($"Vendor ID: {device.Info.ManufacturerString}");
                Console.WriteLine($"Product ID: {device.Info.ProductString}");
                device.Close();
            }
            else {
                Console.WriteLine("No USB device found.");
            }
        }
        catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void MonitorPowerStatus() {
        try {
            Console.WriteLine("Monitoring power status... Not implemented yet.");
        }
        catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
