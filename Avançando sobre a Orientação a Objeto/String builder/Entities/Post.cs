using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() 
        { 
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        } //novamente o list n pode participar do construtor pois ele é 1 para muitos

        //Quando se tem uma relação "tem muitos" é comum add uma operação de add e remove
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        } //tem que fazer mesmo que no diagrama UML não esteja desenhado

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); //ele pertence ao System.Text;
            sb.AppendLine(Title);
                //sb.append add o texto e o sb.appendline add texto+quebra de linha assim como o cw
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("G")); //ao inves de digiar Moment.ToString("dd/MM/yyyy HH:mm:ss"), vc pode digitar Moment.ToString(ctrl+espaço e vai aparecer todo o tipo de formatação disponível)
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments) { 
                sb.AppendLine(c.Text);
            }
            return sb.ToString();//aq converte o stringbuilder inteiro em string. o sb(stringbuilder) é melhor e usa menos memoria/processamento que o toString padrao concadenado com variáveis

        }
    }
}
