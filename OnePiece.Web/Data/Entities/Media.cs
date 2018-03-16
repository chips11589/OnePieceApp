﻿using System.ComponentModel.DataAnnotations.Schema;

namespace OnePiece.Web.Data.Entities
{
    [Table("Medias")]
    public class Media : BaseEntity
    {
        public string Url { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public MediaType Type { get; set; }

        public MediaQuality Quality { get; set; }
    }

    public enum MediaType
    {
        Image = 1, Gif = 2, Video = 3
    }

    public enum MediaQuality
    {
        P360, P540, P720, P1080
    }
}