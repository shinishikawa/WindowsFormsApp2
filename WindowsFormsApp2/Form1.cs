using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private BindingSource wrapper;

        private List<UserModel> original;

        public Form1()
        {
            this.InitializeComponent();

            PictureBox picBox = new PictureBox();
            picBox.ImageLocation = "https://ae01.alicdn.com/kf/HTB1hLiWanQspeRjt_a0q6zPbFXap/Robotime-4-DIY-3D.jpg_50x50.jpg";
            this.original = new List<UserModel>()
        {
            new UserModel()
            {
                Id = "0010",
                FirstName = "Kurihara",
                LastName = "Yuki",
                Email = "yuki.kurihara@gmail.com",
                PicImageUrl = picBox
            },
            new UserModel()
            {
                Id = "0020",
                FirstName = "Momotsuki",
                LastName = "Shinya",
                Email = "shinya.momotsuki@gmail.com",
                PicImageUrl = picBox
        }
        };

            this.wrapper = new BindingSource()
            {
                DataSource = this.original
            };

            this.dataGridView1.DataSource = this.wrapper;
        }
    }
}
