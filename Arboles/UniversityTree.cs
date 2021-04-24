using System;


	class UniversityTree
	{
	public PositionNode Root;

	public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
    {
		PositionNode newNode = new PositionNode();
		newNode.Position = positionToCreate;
		if(Root == null)
        {
			Root = newNode;
			return;
        }

		if(parent == null)
        {
			return;
        }

		if(parent.Position.Name == parentPositionName)
        {
			if(parent.Left == null)
            {
				parent.Left = newNode;
				return;
            }
			parent.Right = newNode;
			return;
        }

		CreatePosition(parent.Left, positionToCreate, parentPositionName);
		CreatePosition(parent.Right, positionToCreate, parentPositionName);
    }

	public void PrintTree(PositionNode from)
    {
		if(from == null)
        {
			return;
        }


        Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");
		PrintTree(from.Left);
		PrintTree(from.Right);

	}

	public float Addsalaries(PositionNode from)
    {
		if (from == null)
		{
			return 0;
		}

		return from.Position.Salary + Addsalaries(from.Left) + Addsalaries(from.Right);
	}

	}

