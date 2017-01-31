/*Topological Sort*/
import java.util.*;
import java.lang.*;
import java.io.*;

class node{
        private ArrayList<node> outBoundEdges;
        private int inBoundEdgeCount;
    }
class Graph{
        private ArrayList<node> nodes;
        public void init(){
            //code to initialize the graph with random edges
            //also add count 
        }
    }    
    
public class TopologicalSort{
    public static void main(String []args){
        Queue order = new Queue();
        Queue processNext =  new Queue();
        
        Graph g = new Graph();
        g.init();
        g.countIncomingEdges();
        processNext = g.getStartingNodes();
        
        while(!processNext.isEmpty()){
            node n = processNext.dequeue();
            for(int i=0;i<n.outBoundEdges.count;i++){
                node otherNode = n.outBoundEdges.get(i);
                otherNode.inBoundEdgeCount--;
                if(otherNode.inBoundCount==0){
                    processEdge.enque(otherNode);
                    order.enque(otherNode);
                }
            }
        }
        if(order.length == g.nodes.length) {
            System.out.println("Completed topological sort");
        }
        else{
            System.out.println("Graph has edges");
        }
    }
}

