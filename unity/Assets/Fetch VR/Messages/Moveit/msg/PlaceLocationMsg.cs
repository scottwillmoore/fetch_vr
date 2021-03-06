//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class PlaceLocationMsg : Message
    {
        public const string k_RosMessageName = "moveit_msgs/PlaceLocation";
        public override string RosMessageName => k_RosMessageName;

        //  A name for this grasp
        public string id;
        //  The internal posture of the hand for the grasp
        //  positions and efforts are used
        public Trajectory.JointTrajectoryMsg post_place_posture;
        //  The position of the end-effector for the grasp relative to a reference frame 
        //  (that is always specified elsewhere, not in this message)
        public Geometry.PoseStampedMsg place_pose;
        //  The approach motion
        public GripperTranslationMsg pre_place_approach;
        //  The retreat motion
        public GripperTranslationMsg post_place_retreat;
        //  an optional list of obstacles that we have semantic information about
        //  and that can be touched/pushed/moved in the course of grasping
        public string[] allowed_touch_objects;

        public PlaceLocationMsg()
        {
            this.id = "";
            this.post_place_posture = new Trajectory.JointTrajectoryMsg();
            this.place_pose = new Geometry.PoseStampedMsg();
            this.pre_place_approach = new GripperTranslationMsg();
            this.post_place_retreat = new GripperTranslationMsg();
            this.allowed_touch_objects = new string[0];
        }

        public PlaceLocationMsg(string id, Trajectory.JointTrajectoryMsg post_place_posture, Geometry.PoseStampedMsg place_pose, GripperTranslationMsg pre_place_approach, GripperTranslationMsg post_place_retreat, string[] allowed_touch_objects)
        {
            this.id = id;
            this.post_place_posture = post_place_posture;
            this.place_pose = place_pose;
            this.pre_place_approach = pre_place_approach;
            this.post_place_retreat = post_place_retreat;
            this.allowed_touch_objects = allowed_touch_objects;
        }

        public static PlaceLocationMsg Deserialize(MessageDeserializer deserializer) => new PlaceLocationMsg(deserializer);

        private PlaceLocationMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.id);
            this.post_place_posture = Trajectory.JointTrajectoryMsg.Deserialize(deserializer);
            this.place_pose = Geometry.PoseStampedMsg.Deserialize(deserializer);
            this.pre_place_approach = GripperTranslationMsg.Deserialize(deserializer);
            this.post_place_retreat = GripperTranslationMsg.Deserialize(deserializer);
            deserializer.Read(out this.allowed_touch_objects, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.id);
            serializer.Write(this.post_place_posture);
            serializer.Write(this.place_pose);
            serializer.Write(this.pre_place_approach);
            serializer.Write(this.post_place_retreat);
            serializer.WriteLength(this.allowed_touch_objects);
            serializer.Write(this.allowed_touch_objects);
        }

        public override string ToString()
        {
            return "PlaceLocationMsg: " +
            "\nid: " + id.ToString() +
            "\npost_place_posture: " + post_place_posture.ToString() +
            "\nplace_pose: " + place_pose.ToString() +
            "\npre_place_approach: " + pre_place_approach.ToString() +
            "\npost_place_retreat: " + post_place_retreat.ToString() +
            "\nallowed_touch_objects: " + System.String.Join(", ", allowed_touch_objects.ToList());
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
