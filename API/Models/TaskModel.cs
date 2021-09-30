using System;

namespace API.Models
{
    public class TaskModel
    {


        //Propriedades ou atributos
        public int Id { get; set; }
        public string NomeTask { get; set; }
        public string DescricaoTask { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString() => $"Nome: {NomeTask}";
    }
}