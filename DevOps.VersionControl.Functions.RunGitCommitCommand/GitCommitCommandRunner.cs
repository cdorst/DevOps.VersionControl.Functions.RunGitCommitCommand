using static Common.Functions.WrapStringInDoubleQuotes.StringWrapper;
using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitCommitCommand
{
    public static class GitCommitCommandRunner
    {
        private const string commit = nameof(commit);
        private const string MessageFlag = "-m";

        public static void Commit(string directory, string message)
            => Git(directory,
                command: commit,
                MessageFlag,
                WrapInDoubleQuotes(message));
    }
}
