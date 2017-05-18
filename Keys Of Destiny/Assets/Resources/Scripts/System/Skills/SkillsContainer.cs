﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml.Serialization;
using System.IO;

[XmlRoot("SkillsCollection")]
public class SkillsContainer {


    [XmlArray("Skills")]
    [XmlArrayItem("AtaqueBasico")]
    public List<Skills> ataqueBasicos = new List<Skills>();
    [XmlArrayItem("AtaqueSecundario")]
    public List<Skills> ataqueSecundarios = new List<Skills>();
    [XmlArrayItem("Skill")]
    public List<Skills> skills = new List<Skills>();
    [XmlArrayItem("SkillMovement")]
    public List<Skills> skillsMovement = new List<Skills>();


    public static SkillsContainer Load(string path)
    {
        TextAsset xmlFile = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(SkillsContainer));
        StringReader reader = new StringReader(xmlFile.text);



        SkillsContainer ataqueBasicos = serializer.Deserialize(reader) as SkillsContainer;
        reader.Close();

        return ataqueBasicos;
    }




}
