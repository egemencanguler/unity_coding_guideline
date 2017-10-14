// extended version of http://wiki.unity3d.com/index.php/Csharp_Coding_Guidelines

//Open braces should always be at the beginning of the line after the statement that begins the block.
if (someExpression)
{
   DoSomething();
}
else
{
   DoSomethingElse();
}

// “case” statements should be indented from the switch statement like this:

switch (someExpression) 
{
 
   case 0:
      DoSomething();
      break;
 
   case 1:
      DoSomethingElse();
      break;
 
   case 2: 
      {
         int n = 1;
         DoAnotherThing(n);
      }
      break;
}

// Braces should never be considered optional. Even for single statement blocks, you should always use braces.
for (int i=0; i<100; i++) { DoSomething(i); }

// pascal case for class names
public class ClassName
{
	// use PascalCase in constant names
	private const int TheConstant = 10;
	// camelCase for pulic and private variables
   int bar;
 
 // field has the same name with the corresponding private variable but in uppercase
   public int Bar
   {
      get { return bar; }
      set { bar = value; }
   }

   // use camel case in function names
   public void DoSomething()
   {

   }

   // add C prefix in couroutine names
   public IEnumerator CDoSometing()
   {

   }


 
}

// always add Prefab suffix to prefab reference
public GameObject enemyPrefab;
// use plural forms in enum names
enum Types
{
	Type1,Type2
}


// use camelCase to name the gameobjects inside the scene
