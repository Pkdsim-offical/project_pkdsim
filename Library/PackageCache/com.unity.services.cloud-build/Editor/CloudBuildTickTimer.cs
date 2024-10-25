using UnityEditor;

namespace Unity.Services.CloudBuild.Editor
{
    class CloudBuildTickTimer
    {
        double m_NextTick;
        double m_IntervalInSeconds;

        public CloudBuildTickTimer(double intervalBetweenTicksInSeconds)
        {
            m_IntervalInSeconds = intervalBetweenTicksInSeconds;
        }

        public bool Tick()
        {
            if (EditorApplication.timeSinceStartup > m_NextTick)
            {
                m_NextTick = EditorApplication.timeSinceStartup + m_IntervalInSeconds;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            m_NextTick = 0;
        }
    }
}
