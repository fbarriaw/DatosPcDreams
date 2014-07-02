using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;

namespace DatosPcDreams
{
    public partial class Form2 : Form
    {
        int contNameFile = 0;
        public Form2()
        {
            
            InitializeComponent();
        }

       private void btn_PrintScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(1000);
            this.contNameFile++;
            Bitmap BmpScreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                      Screen.PrimaryScreen.Bounds.Height,
                              System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            Graphics ScreenShot = Graphics.FromImage(BmpScreen);

            ScreenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                      Screen.PrimaryScreen.Bounds.Y, 0, 0,
                     Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

           // string fileNom = "Pantallazo";
            saveFileDialog1.FileName = "Pantallazo" + this.contNameFile; ;

            saveFileDialog1.Filter = "Archivos png (*.png)|*.png";

            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileNom = saveFileDialog1.FileName;


                BmpScreen.Save(fileNom, System.Drawing.Imaging.ImageFormat.Png);
            }
            this.Show();
        }

       private void bnt_SendPrintScreen_Click(object sender, EventArgs e)
       {
           //Se prepara un nuevo mensaje
           System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

           //Se establece el destinatario
           msg.To.Add("dunk_frbw@hotmail.com");
           msg.To.Add("fbarriaw@gmail.com");

           //Se establece el remitente, asi como el nombre que aparecerá en la 
           //bandeja de entrada, así como el formato de codificación
           msg.From = new MailAddress("fbarriaw@gmail.com", "Freddy", System.Text.Encoding.UTF8);

           //Se establece el asunto del mail
           msg.Subject = "Prueba de correo";

           //Formato de codificación del Asunto
           msg.SubjectEncoding = System.Text.Encoding.UTF8;

           //Se establece el cuerpo del mail
           msg.Body = "Correo de ejemplo y prueba del sistema de captura de pantalla";

           //Se establece la codificación del Cuerpo
           msg.BodyEncoding = System.Text.Encoding.UTF8;

           //Se indica si al cuerpo del mail, se interpretara como código HTMl
           //o no, esto funciona cuando queremos que aparezca centrado algo 
           //mediante , etc
           msg.IsBodyHtml = false;

           //Se establece la cadena de texto con la ubicación del archivo a 
           //adjuntar
           OpenFileDialog o = new OpenFileDialog();
           o.Filter = "Archivos png (*.png)|*.png";
           o.RestoreDirectory = true;
           
           //Se adjunta el archivo
           if (o.ShowDialog() == DialogResult.OK)
           {
               string file = o.FileName;
               Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
               ContentDisposition disposition = data.ContentDisposition;
               disposition.CreationDate = System.IO.File.GetCreationTime(file);
               disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
               disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
               msg.Attachments.Add(data);

               //Se prepara el envio del mail
               SmtpClient client = new SmtpClient();

               //Se establecen las credenciales para enviar el mail, muy importante autentificarse con la cuenta de correo y la contraseña
               client.Credentials = new System.Net.NetworkCredential("fbarriaw@gmail.com", "year300095539042");

               //Se establece el puerto de envio
               client.Port = 587;

               //Se establece el servidor SMTP, en este caso GMAIL
               client.Host = "smtp.gmail.com";
               //Seguridad SSL?, si como no, prueben ettereal
               client.EnableSsl = true;

               //Se envia el Mail
               try
               {
                   client.Send(msg);
               }
               catch (System.Net.Mail.SmtpException ex)
               {
                   Console.WriteLine(ex.Message);
                   Console.ReadLine();
               }
               MessageBox.Show("Las imagenes han sido enviadas");
           }
           
       }

       private void btn_Exit_Click(object sender, EventArgs e)
       {
           this.contNameFile = 0;
           this.Close();
           }  
    }
}
