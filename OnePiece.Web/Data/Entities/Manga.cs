﻿using System.Collections.Generic;

namespace OnePiece.Web.Data.Entities
{
    public class Manga : BaseEntity
    {
        public int ChapterNumber { get; set; }

        public int TotalPages { get; set; }

        public string Title { get; set; }

        public string TitleEng { get; set; }

        public string Description { get; set; }

        public string DescriptionEng { get; set; }

        public decimal? Rating { get; set; }

        public int? ViewCount { get; set; }

        public string Cover { get; set; }

        public string Poster { get; set; }

        public MangaType Type { get; set; }

        public string PagesJson { get; set; }

        public List<MangaPage> MangaPages { get; set; }

        public int SeasonId { get; set; }

        public Season Season { get; set; }

        public int? VolumeId { get; set; }

        public Volume Volume { get; set; }
    }

    public enum MangaType
    {
        BlackWhite,
        Color
    }
}
