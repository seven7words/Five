using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace 二叉排序树_链式存储
{
    class BSTree
    {

        BSNode root = null;

        //添加数据
        public void Add(int item)
        {
            BSNode newNode = new BSNode(item);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BSNode temp = root;
                while (true)
                {
                    if (item >= temp.Data)//放在temp的右边
                    {
                        if (temp.RightChild == null)
                        {
                            temp.RightChild = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.RightChild;
                        }
                    }
                    else//放在temp的左边
                    {
                        if (temp.LeftChild == null)
                        {
                            temp.LeftChild = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.LeftChild;
                        }
                    }
                }
            }
        }

        public void MiddleTraversal()
        {
            MiddleTraversal(root);
        }
        private void MiddleTraversal(BSNode node)
        {
            if (node == null) return;

            MiddleTraversal(node.LeftChild);
            Console.Write(node.Data + " ");
            MiddleTraversal(node.RightChild);

        }

        public bool Find(int item)
        {
            //return Find(item, root);
            BSNode temp = root;
            while (true)
            {
                if (temp == null)
                    return false;
                if (temp.Data == item)
                    return true;
                if (temp.Data < item)
                {
                    temp = temp.RightChild;
                }
                else
                {
                    temp = temp.LeftChild;
                }
            }
        }
        private bool Find(int item,BSNode node)
        {
            if (node == null) return false;
            if (node.Data == item)
            {
                return true;
            }
            else
            {
                if (item > node.Data)
                {
                   return Find(item, node.RightChild);
                }
                else
                {
                   return Find(item, node.LeftChild);
                }
                //if (Find(item, node.LeftChild))
                //{
                //    return true;
                //}
                //if (Find(item, node.RightChild))
                //{
                //    return true;
                //}
            }


        }
        public bool Delete(int item)
        {
            BSNode temp = root;
            while (true)
            {
                if (temp == null)
                    return false;
                if (temp.Data == item)
                {
                    Delete(temp);
                    return true;
                }
                    
                if (temp.Data < item)
                {
                    temp = temp.RightChild;
                }
                else
                {
                    temp = temp.LeftChild;
                }
            }
        }

        public void Delete(BSNode node)
        {
            if (node.LeftChild == null && node.RightChild == null)
            {
                if (node.Parent == null)
                {
                    root = null;
                }
                if (node.Parent.LeftChild == node)
                {
                    node.Parent.LeftChild = null;
                }
                else if(node.Parent.RightChild == null)
                {
                    node.Parent.RightChild = null;
                }
                return;
            }
            if (node.LeftChild == null && node.RightChild != null)
            {
                node.Data = node.RightChild.Data;
                node.RightChild = null;
                return;
            }
            if (node.LeftChild != null && node.RightChild == null)
            {
                node.Data = node.LeftChild.Data;
                node.LeftChild = null;
                return;
            }
            BSNode newTemp = node.RightChild;
            while (true)
            {
                if (newTemp.LeftChild != null)
                {
                    newTemp = newTemp.LeftChild;

                }
                else
                {
                    break;
                }
                node.Data = newTemp.Data;
                Delete(newTemp);
            }

        }

    }
    
}
