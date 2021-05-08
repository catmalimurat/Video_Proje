using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Video
/// </summary>
public class Video
{
    string vkod, d_video;
    public Video()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Vkod { get => vkod; set => vkod = value; }
    public string D_video { get => d_video; set => d_video = value; }
}