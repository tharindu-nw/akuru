using UnityEngine;
using System.Collections;

//Hierrachy Manager Script
public class HierrachyManager : MonoBehaviour
{
		//Get direct child
		public static GameObject getDirectChild (GameObject root, string childname)
		{
				if (root == null) {
						return null;	
				}
				
				Transform rootTransfrom = root.transform;

				if (rootTransfrom == null) {
						return null;
				}
				Transform childTransform = rootTransfrom.Find (childname);
				if (childTransform == null) {
						return null;
				}
				return childTransform.gameObject;
		}

		//Get a parent
		public static GameObject getAParent (GameObject child, string parentname)
		{
				if (child == null) {
						return null;	
				}
				Transform transparent = child.transform.parent;
				if (transparent == null) {
						return null;	
				}
				GameObject parent = transparent.gameObject;
				if (parent.name == parentname) {
						return parent;
				}
				return getAParent (parent, parentname);
		}

		//Find active gameobject with name
		public static  GameObject FindActiveGameObjectWithName (string name)
		{
				return GameObject.Find (name);
		}

		//fine active gameobject with tag
		public static GameObject FindActiveGameObjectWithTag (string tag)
		{
				return GameObject.FindGameObjectWithTag (tag);
		}

		//find active gameobjects with tag
		public static GameObject[] FindActiveGameObjectsWithTag (string tag)
		{
				return GameObject.FindGameObjectsWithTag (tag);
		}
}
