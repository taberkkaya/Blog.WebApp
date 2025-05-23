﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AK.BlogWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AK.BlogWebApp.Infrastructure.Configurations;

internal class DocumentConfiguration : IEntityTypeConfiguration<Document>
{
    public void Configure(EntityTypeBuilder<Document> builder)
    {
        Document document1 = new()
        {
            Id = Guid.Parse("4F802B23-DD96-41A9-88BC-8E923CBA6BE9"),
            Title = "What is Lorem Ipsum?\r\n",
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\n",
            CoverImgUrl = "angular_20250510_033510.png",
            DocumentCategoryId = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            DocumentUrl = "angular_20250510_033510.png",
            IsFeatured = false
        };

        Document document2 = new()
        {
            Id = Guid.Parse("692158C3-96B4-4749-8FA3-1C9568281445"),
            Title = "Where does it come from?\r\n",
            Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\n",
            CoverImgUrl = "dotnet_2_20250510_033455.png",
            DocumentCategoryId = Guid.Parse("0B6C5C91-9D48-4E9B-8B5D-FED05BE56A73"),
            DocumentUrl = "angular_20250510_033528.png",
            IsFeatured = false
        };

        Document document3 = new()
        {
            Id = Guid.Parse("270445C6-56F7-46EB-B27F-A01E2885C0E7"),
            Title = "What is Lorem Ipsum?\r\n",
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\n",
            CoverImgUrl = "dotnet_2_20250510_033541.png",
            DocumentCategoryId = Guid.Parse("6DEF4F3D-93B9-4C24-97E1-143499F2955F"),
            DocumentUrl = "dotnet_2_20250510_033455.png",
            IsFeatured = true
        };

        Document document4 = new()
        {
            Id = Guid.Parse("05283987-D4C9-48B3-9E42-06BC362805F3"),
            Title = "What is Lorem Ipsum?\r\n",
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\n",
            CoverImgUrl = "full-stack-devlopment-min_20250510_033528.png",
            DocumentCategoryId = Guid.Parse("D7A19C6C-0D9F-4D10-9207-CFC9C8499A32"),
            DocumentUrl = "dotnet_2_20250510_033541.png",
            IsFeatured = true
        };

        Document document5 = new()
        {
            Id = Guid.Parse("B7B9E1CC-1625-474F-A40E-E4CC1371D719"),
            Title = "What is Lorem Ipsum?\r\n",
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\n",
            CoverImgUrl = "rest-api_20250510_033440.jpg",
            DocumentCategoryId = Guid.Parse("D7A19C6C-0D9F-4D10-9207-CFC9C8499A32"),
            DocumentUrl = "dotnet_2_20250510_033559.png",
            IsFeatured = true
        };

        List<Document> documents = new()
        {
            document1,
            document2,
            document3,
            document4,
            document5
        };

        builder.HasData(documents);
    }
}
