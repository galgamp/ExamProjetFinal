using System;
using System.Collections.Generic;
using System.Text;

namespace ExamFinal.Mobile.UI.Models
{

        public class ResponseTime
{
    public double time { get; set; }
    public string measure { get; set; }
}
public class Meta
{
    public int code { get; set; }
    public ResponseTime response_time { get; set; }
}
public class Pagination
{
    public string nexturl { get; set; }
    public int maxid { get; set; }
    public string since_url { get; set; }
}
public class Contact
{
    public string twitter { get; set; }
    public int foursquare { get; set; }
}
public class User
{
    public int uid { get; set; }
    public string username { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string location { get; set; }
    public string url { get; set; }
    public object relationship { get; set; }
    public string bio { get; set; }
    public string useravatar { get; set; }
    public Contact contact { get; set; }
}
public class Beer
{
    public int bid { get; set; }
    public string beername { get; set; }
    public string beerlabel { get; set; }
    public string beer_style { get; set; }
    public int authrating { get; set; }
    public bool wishlist { get; set; }
}
public class Contact2
{
    public string twitter { get; set; }
    public string facebook { get; set; }
    public string url { get; set; }
}
public class Location
{
    public string brewerycity { get; set; }
    public string brewerystate { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
}
public class Brewery
{
    public int breweryid { get; set; }
    public string breweryname { get; set; }
    public string brewerylabel { get; set; }
    public string countryname { get; set; }
    public Contact2 contact { get; set; }
    public Location location { get; set; }
}
public class Comments
{
    public int count { get; set; }
    public List<object> items { get; set; }
}
public class Toasts
{
    public int count { get; set; }
    public object auth_toast { get; set; }
    public List<object> items { get; set; }
}
public class Media
{
    public int count { get; set; }
    public List<object> items { get; set; }
}
public class Item
{
    public int checkinid { get; set; }
    public string createdat { get; set; }
    public string checkin_comment { get; set; }
    public User user { get; set; }
    public Beer beer { get; set; }
    public Brewery brewery { get; set; }
    public List<object> venue { get; set; }
    public Comments comments { get; set; }
    public Toasts toasts { get; set; }
    public Media media { get; set; }
}
public class Checkins
{
    public int count { get; set; }
    public List<string> items { get; set; }
}
public class Response
{
    public Pagination pagination { get; set; }
    public Checkins checkins { get; set; }
}
public class RootObject
{
    public Meta meta { get; set; }
    public List<object> notifications { get; set; }
    public Response response { get; set; }
}
}
