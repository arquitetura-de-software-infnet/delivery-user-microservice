using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUsuarios.Messages.Models
{
    /// <summary>
    /// Modelo de dados para envio de email
    /// </summary>
    public class EmailMessageModel
    {

        //Email do destinatário da mensagem
        public string MailTo { get; set; }

        //Assunto da mensagem
        public string Subject { get; set; }

        //Conteúdo / corpo da mensagem
        public string Body { get; set; }
    }
}
