public void Main(string argument) 
{
	argument = argument.ToLower();
	
	if(argument == "green")
	{
		LowerPistons(false);
		HydDoor(false);
		OxyDoor(false);
		FrontDoor(false);
		ReactorDoor(false);
		ShieldDoor(false);
		CommCenterDoors(false);
		ReactorBlastDoors(false);
	}
	else if(argument == "red")
	{
		LowerPistons(true);
		HydDoor(true);
		OxyDoor(true);
		FrontDoor(true);		
		ReactorDoor(true);
		ShieldDoor(true);
		CommCenterDoors(true);
		ReactorBlastDoors(true);
	}
	else if(argument == "yellow")
	{
		LowerPistons(false);
		HydDoor(false);
		FrontDoor(false);
		OxyDoor(false);
		ReactorDoor(false);
		ShieldDoor(false);
		CommCenterDoors(false);
		ReactorBlastDoors(false);
	}
	else
	{
		FrontDoor(false);
		LowerPistons(false);
		HydDoor(false);
		OxyDoor(false);
		ReactorDoor(false);
		ShieldDoor(false);
		CommCenterDoors(false);
		ReactorBlastDoors(false);
	}
	
	AlertStatus(argument);
}


public void LowerPistons(bool Extend)
{
	var LowerPistonGroup1 = GetGroup("Lower CC Pistons 1");
	var LowerPistonGroup2 = GetGroup("Lower CC Pistons 2");
	var UpperPistonsGroup1 = GetGroup("Upper CC Pistons 1");
	var UpperPistonsGroup2 = GetGroup("Upper CC Pistons 2");
	
	if(LowerPistonGroup1 != null)
    {
		for(int j = 0; j < LowerPistonGroup1.Count; j++)
		{
			IMyPistonBase piston1 = LowerPistonGroup1[j] as IMyPistonBase;
			
			if(Extend == true)
			{
				if(piston1.Status == PistonStatus.Retracted || piston1.Status == PistonStatus.Retracting)
				{
					piston1.ApplyAction("Reverse");
				}
			}
			else
			{
				if(piston1.Status == PistonStatus.Extended|| piston1.Status == PistonStatus.Extending)
				{
					piston1.ApplyAction("Reverse");
				}
			}
		}
    }
	
	if(LowerPistonGroup2 != null)
    {
		for(int j = 0; j < LowerPistonGroup2.Count; j++)
		{
			IMyPistonBase piston1 = LowerPistonGroup2[j] as IMyPistonBase;
			
			if(Extend == true)
			{
				if(piston1.Status == PistonStatus.Retracted || piston1.Status == PistonStatus.Retracting)
				{
					piston1.ApplyAction("Reverse");
				}
			}
			else
			{
				if(piston1.Status == PistonStatus.Extended|| piston1.Status == PistonStatus.Extending)
				{
					piston1.ApplyAction("Reverse");
				}
			}
		}
    }
	
	if(UpperPistonsGroup1 != null)
    {
		for(int j = 0; j < UpperPistonsGroup1.Count; j++)
		{
			IMyPistonBase piston1 = UpperPistonsGroup1[j] as IMyPistonBase;
			
			if(Extend == true)
			{
				if(piston1.Status == PistonStatus.Retracted || piston1.Status == PistonStatus.Retracting)
				{
					piston1.ApplyAction("Reverse");
				}
			}
			else
			{
				if(piston1.Status == PistonStatus.Extended|| piston1.Status == PistonStatus.Extending)
				{
					piston1.ApplyAction("Reverse");
				}
			}
		}
    }
	
	if(UpperPistonsGroup2 != null)
    {
		for(int j = 0; j < UpperPistonsGroup2.Count; j++)
		{
			IMyPistonBase piston1 = UpperPistonsGroup2[j] as IMyPistonBase;
			
			if(Extend == true)
			{
				if(piston1.Status == PistonStatus.Retracted || piston1.Status == PistonStatus.Retracting)
				{
					piston1.ApplyAction("Reverse");
				}
			}
			else
			{
				if(piston1.Status == PistonStatus.Extended|| piston1.Status == PistonStatus.Extending)
				{
					piston1.ApplyAction("Reverse");
				}
			}
		}
    }
}

public void HydDoor(bool Close)
{
    var DoorGroup = GetGroup("Hydrogen Doors");

    if(DoorGroup != null)
    {
		for(int j = 0; j < DoorGroup.Count; j++)
		{
			IMyDoor door = DoorGroup[j] as IMyDoor;
			
			if(Close == true)
			{
				door.ApplyAction("Open_Off");
			}
			else
			{
				door.ApplyAction("Open_On");
			}
		}
    }
}

public void FrontDoor(bool Close)
{
    var DoorGroup = GetGroup("Front Hanger Doors");

    if(DoorGroup != null)
    {
		for(int j = 0; j < DoorGroup.Count; j++)
		{
			IMyDoor door = DoorGroup[j] as IMyDoor;
			
			if(Close == true)
			{
				door.ApplyAction("Open_Off");
			}
			else
			{
				door.ApplyAction("Open_On");
			}
		}
    }
}

public void OxyDoor(bool Close)
{
    var DoorGroup = GetGroup("Oxygen Room Doors"); 
 
	if(DoorGroup != null)
    {
		for(int j = 0; j < DoorGroup.Count; j++)
		{
			IMyDoor door = DoorGroup[j] as IMyDoor;
			
			if(Close == true)
			{
				door.ApplyAction("Open_Off");
			}
			else
			{
				door.ApplyAction("Open_On");
			}
		}
    }
}

public void ReactorDoor(bool Close)
{
    var DoorGroup = GetGroup("Reactor Doors"); 
 
	if(DoorGroup != null)
    {
		for(int j = 0; j < DoorGroup.Count; j++)
		{
			IMyDoor door = DoorGroup[j] as IMyDoor;
			
			if(Close == true)
			{
				door.ApplyAction("Open_Off");
			}
			else
			{
				door.ApplyAction("Open_On");
			}
		}
    }
}

public void ShieldDoor(bool Close)
{
    var DoorGroup = GetGroup("Shield Generator Doors"); 
 
	if(DoorGroup != null)
    {
		for(int j = 0; j < DoorGroup.Count; j++)
		{
			IMyDoor door = DoorGroup[j] as IMyDoor;
			
			if(Close == true)
			{
				door.ApplyAction("Open_Off");
			}
			else
			{
				door.ApplyAction("Open_On");
			}
		}
    }
}

public void CommCenterDoors(bool Extend)
{
	IMyPistonBase piston1 = GridTerminalSystem.GetBlockWithName("Command Center Door 1") as IMyPistonBase;
	IMyPistonBase piston2 = GridTerminalSystem.GetBlockWithName("Command Center Door 2") as IMyPistonBase;
	
	if(piston1 != null)
	{
		if(Extend == true)
		{
			if(piston1.Status == PistonStatus.Retracted || piston1.Status == PistonStatus.Retracting)
			{
				piston1.ApplyAction("Reverse");
			}
		}
		else
		{
			if(piston1.Status == PistonStatus.Extended|| piston1.Status == PistonStatus.Extending)
			{
				piston1.ApplyAction("Reverse");
			}
		}
	}
	
	if(piston2 != null)
	{
		if(Extend == true)
		{
			if(piston2.Status == PistonStatus.Retracted || piston2.Status == PistonStatus.Retracting)
			{
				piston2.ApplyAction("Reverse");
			}
		}
		else
		{
			if(piston2.Status == PistonStatus.Extended|| piston2.Status == PistonStatus.Extending)
			{
				piston2.ApplyAction("Reverse");
			}
		}
	}
}

public void ReactorBlastDoors(bool Extend)
{
 	IMyPistonBase piston1 = GridTerminalSystem.GetBlockWithName("Reactor Outer Door Piston 1") as IMyPistonBase;
	IMyPistonBase piston2 = GridTerminalSystem.GetBlockWithName("Reactor Outer Door Piston 2") as IMyPistonBase;
	
	if(piston1 != null)
	{
		if(Extend == true)
		{
			if(piston1.Status == PistonStatus.Retracted || piston1.Status == PistonStatus.Retracting)
			{
				piston1.ApplyAction("Reverse");
			}
		}
		else
		{
			if(piston1.Status == PistonStatus.Extended|| piston1.Status == PistonStatus.Extending)
			{
				piston1.ApplyAction("Reverse");
			}
		}
	}
	
	if(piston2 != null)
	{
		if(Extend == true)
		{
			if(piston2.Status == PistonStatus.Retracted || piston2.Status == PistonStatus.Retracting)
			{
				piston2.ApplyAction("Reverse");
			}
		}
		else
		{
			if(piston2.Status == PistonStatus.Extended|| piston2.Status == PistonStatus.Extending)
			{
				piston2.ApplyAction("Reverse");
			}
		}
	}
}

public List<IMyTerminalBlock> GetGroup(string GroupName)
{
    var Groups = new List<IMyBlockGroup>(); 
    GridTerminalSystem.GetBlockGroups(Groups);

    for(int i = 0; i < Groups.Count; i++) 
    { 
        if(Groups[i].Name == GroupName) 
        { 
            //Echo("Found Group"); 
            List<IMyTerminalBlock> FoundGroup = new List<IMyTerminalBlock>(); 
            Groups[i].GetBlocks(FoundGroup);

            return FoundGroup;
        }
    }

    return null;
}

public void AlertStatus(string argument)
{
	var GroupName = "Command Center Lights";
    var Groups = new List<IMyBlockGroup>();
    GridTerminalSystem.GetBlockGroups(Groups);
    //Echo("Groups.Count" + Groups.Count.ToString());
    for(int i = 0; i < Groups.Count; i++)
    {
        if(Groups[i].Name == GroupName)
        {
            //Echo("Found Group");
            List<IMyTerminalBlock> Lights = new List<IMyTerminalBlock>();
            Groups[i].GetBlocks(Lights);
            //Echo("Lights" + Lights.Count.ToString());

            for(int j = 0; j < Lights.Count; j++)
            {
                ChangeLightColor(Lights[j] as IMyLightingBlock, ChooseColor(argument));
                ChangeBlinkSpeed(Lights[j] as IMyLightingBlock, argument);
                //Echo("Light");
            }
        }
    }
}

public Color ChooseColor(string argument)
{
    if(argument == "red")
    {
        return new Color(255, 0, 0);
    } 
    else if(argument == "green") 
    { 
        return new Color(0, 255, 71);
    }  
    else if(argument == "yellow")  
    {  
        return new Color(255, 255, 141);
    }
    else
    {
        return new Color(255, 255, 255);
    }
}

public void ChangeLightColor(IMyLightingBlock InLight, Color NewColor)
{
    if(InLight != null && NewColor != null)
    {        
        InLight.SetValue("Color", NewColor);
    }
}


public void ChangeBlinkSpeed(IMyLightingBlock InLight, string argument)
{
    if(InLight != null) 
    {
       if(argument == "red") 
        { 
             InLight.SetValueFloat("Blink Interval", 1f); 
        }  
        else if(argument == "green")  
        {  
            //Echo("Got Light");
             InLight.SetValueFloat("Blink Interval", 0f); 
        }   
        else if(argument == "yellow")   
        {   
             InLight.SetValueFloat("Blink Interval", 3f); 
        } 
        else 
        { 
             InLight.SetValueFloat("Blink Interval", 0f); 
        }        
    }
}
