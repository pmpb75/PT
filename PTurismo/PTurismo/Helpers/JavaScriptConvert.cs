﻿using System;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PTurismo.Helpers
{
    public static class JavaScriptConvert
    {
        public static IHtmlString SerializeObject(object value)
        {
            using (var stringWriter = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                

                var serializer =
                    JsonSerializer.Create(new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore,
                        Formatting = Formatting.Indented
                    });
            
                

                // We don't want quotes around object names
                jsonWriter.QuoteName = false;

             
                serializer.Serialize(jsonWriter, value);
                
               
                return new HtmlString(stringWriter.ToString());
            }
        }
    }
}