using MailKit.Net.Smtp;
using MimeKit;
using System;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class EmailService
    {
        public void EnviarEmail(string[] destinatario, string assunto, int usuarioId, string code)
        {
            Mensagem mensagem = new Mensagem(destinatario, assunto, usuarioId, code);
            var mensagemDeEmail = CriaCorpoDoEmail(mensagem);
            Enviar(mensagemDeEmail);
        }

        private void Enviar(MimeMessage mensagemDeEmail)
        {
            using(var client = new SmtpClient())
            {
                try
                {
                    client.Connect("Conexão a fazer");
                    // TODO Auth de e-mail
                    client.Send(mensagemDeEmail);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private MimeMessage CriaCorpoDoEmail(Mensagem mensagem)
        {
            var mensagemDeEmail = new MimeMessage();
            mensagemDeEmail.From.Add(new MailboxAddress("ADICIONAR O REMETENTE"));
            mensagemDeEmail.To.AddRange(mensagem.Destinatario);
            mensagemDeEmail.Subject = mensagem.Assunto;
            mensagemDeEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = mensagem.Conteudo
            };

            return mensagemDeEmail;
        }
    }
}
