
using Princess_Connect.Data.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class DataModel
{
    private Data data = null;

    public DataModel()
    {
        data = new Data();
    }

    public List<SQL_Story> getAll()
    {
        return data.SQL_Story.ToList();
    }

    public SQL_Story getDetail(String NV)
    {
        var result = data.SQL_Story.FirstOrDefault(b => b.Character_Id == NV);
        if(result != null)
        {
            return result;
        }
        else
        {
            return null;
        }
    }

    public bool Create(SQL_Character sQL_Character, SQL_Story sQL_Story)
    {
        try
        {
            data.SQL_Character.Add(sQL_Character);
            data.SaveChanges();
            data.SQL_Story.Add(sQL_Story);
            data.SaveChanges();
            return true;
        }
        catch(Exception e)
        {
            e.Message.ToString();
            return false;
        }
    }

    public bool UpdateStory(SQL_Story sQL_Story)
    {
        var result = data.SQL_Story.FirstOrDefault(b => b.Character_Id == sQL_Story.Character_Id);
        if(result != null)
        {
            result.SQL_Character.Character_Name = sQL_Story.SQL_Character.Character_Name;
            result.SQL_Character.Character_Picture = sQL_Story.SQL_Character.Character_Picture;

            data.SaveChanges();
            return true;
        }
        else
        {
            return false;
        }
    }
}