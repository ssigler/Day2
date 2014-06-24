using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.AccessCache;

namespace ImageUploader.Common
{
    public static class CasualFriday
    {
        public async static Task(Windows.UI.Xaml.Media.Imaging.BitmapImage); 
        public async static uploadImagetoFAL(Windows.Storage.StorageFile addFile)
    {
                    AccessListEntryView mruEntries = StorageApplicationPermissions.FutureAccessList.Entries;
                        // Open the file via the token that you stored when adding this file into the MRU list.
                            string falFirstToken= Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.Entries[0].Token;
                            Windows.Storage.StorageFile file = await Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.GetFileAsync(falFirstToken);


                            Windows.Storage.Streams.IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);

                            // Set the image source to a bitmap.
                            Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage =
                                new Windows.UI.Xaml.Media.Imaging.BitmapImage();

                            bitmapImage.SetSource(fileStream);
                            addFile.Source = bitmapImage;

                            // Set the data context for the page.
                            return  addFile ; 
    }
    }      
}

