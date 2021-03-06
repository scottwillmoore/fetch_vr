//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Aruco
{
    [Serializable]
    public class MarkerArrayMsg : Message
    {
        public const string k_RosMessageName = "aruco_msgs/MarkerArray";
        public override string RosMessageName => k_RosMessageName;

        public HeaderMsg header;
        public MarkerMsg[] markers;

        public MarkerArrayMsg()
        {
            this.header = new HeaderMsg();
            this.markers = new MarkerMsg[0];
        }

        public MarkerArrayMsg(HeaderMsg header, MarkerMsg[] markers)
        {
            this.header = header;
            this.markers = markers;
        }

        public static MarkerArrayMsg Deserialize(MessageDeserializer deserializer) => new MarkerArrayMsg(deserializer);

        private MarkerArrayMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.markers, MarkerMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.WriteLength(this.markers);
            serializer.Write(this.markers);
        }

        public override string ToString()
        {
            return "MarkerArrayMsg: " +
            "\nheader: " + header.ToString() +
            "\nmarkers: " + System.String.Join(", ", markers.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
