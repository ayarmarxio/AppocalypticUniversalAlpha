using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppocalypticUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QuizPage : Page
    {
        public QuizPage()
        {
            this.InitializeComponent();
            
        }


        

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            String fileEnergy = @"\Assets\energy questions.txt";
            String content = "";

            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///" + fileEnergy));

            using (StreamReader reader = new StreamReader(await file.OpenStreamForReadAsync()))
            {
                content = reader.ReadToEnd();
            }

            char spliter = '#';
            String[] energyvalue = content.Split(spliter);

            ///////////////////////////

            String fileMind = @"\Assets\mind questions.txt";
            String content2 = "";

            StorageFile file2 = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///" + fileMind));

            using (StreamReader reader = new StreamReader(await file2.OpenStreamForReadAsync()))
            {
                content2 = reader.ReadToEnd();
            }

            String[] mindvalue = content2.Split(spliter);

            ///////////////////////////

            String fileId = @"\Assets\identity questions.txt";
            String content3 = "";

            StorageFile file3 = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///" + fileId));

            using (StreamReader reader = new StreamReader(await file3.OpenStreamForReadAsync()))
            {
                content3 = reader.ReadToEnd();
            }

            String[] IdValue = content3.Split(spliter);

            ///////////////////////////

            String fileNature = @"\Assets\nature questions.txt";
            String content4 = "";

            StorageFile file4 = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///" + fileNature));

            using (StreamReader reader = new StreamReader(await file4.OpenStreamForReadAsync()))
            {
                content4 = reader.ReadToEnd();
            }

            String[] NatureValue = content4.Split(spliter);

            ///////////////////////////

            String fileTactics = @"\Assets\tactics questions.txt";
            String content5 = "";

            StorageFile file5 = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///" + fileTactics));

            using (StreamReader reader = new StreamReader(await file5.OpenStreamForReadAsync()))
            {
                content5 = reader.ReadToEnd();
            }

            String[] TacticsValue = content5.Split(spliter);


            if (page.Text == "1")
            {
                q1.Text = energyvalue[1];
                q2.Text = mindvalue[1];
                q3.Text = IdValue[1];
                q4.Text = NatureValue[1];
                q5.Text = TacticsValue[1];
                page.Text = "2";
            }
            else if (page.Text == "2")
            {
                q1.Text = energyvalue[2];
                q2.Text = mindvalue[2];
                q3.Text = IdValue[2];
                q4.Text = NatureValue[2];
                q5.Text = TacticsValue[2];
                page.Text = "3";
            }
            else if (page.Text == "3")
            {
                q1.Text = energyvalue[3];
                q2.Text = mindvalue[3];
                q3.Text = IdValue[3];
                q4.Text = NatureValue[3];
                q5.Text = TacticsValue[3];
                page.Text = "4";
            }
            else if (page.Text == "4")
            {
                q1.Text = energyvalue[4];
                q2.Text = mindvalue[4];
                q3.Text = IdValue[4];
                q4.Text = NatureValue[4];
                q5.Text = TacticsValue[4];
                page.Text = "5";
            }
            else if (page.Text == "5")
            {
                q1.Text = energyvalue[5];
                q2.Text = mindvalue[5];
                q3.Text = IdValue[5];
                q4.Text = NatureValue[5];
                q5.Text = TacticsValue[5];
                page.Text = "";
            }

        }
    }
}
