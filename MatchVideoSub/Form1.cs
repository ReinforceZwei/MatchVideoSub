using System.Diagnostics;

namespace MatchVideoSub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Match Video Subtitle";
        }

        private void videoDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                var fileAttr = File.GetAttributes(file);
                if (fileAttr.HasFlag(FileAttributes.Directory))
                {
                    // Show files in that directory
                    foreach (var dirFile in Directory.GetFiles(file))
                    {
                        if (!MatchSub.FileShouldExclude(Path.GetFileName(dirFile)))
                        {
                            videoListBox.Items.Add(dirFile);
                            videoListBox.SetItemChecked(videoListBox.Items.Count - 1, true);
                        }
                    }
                }
                else
                {
                    if (!MatchSub.FileShouldExclude(Path.GetFileName(file)))
                    {
                        videoListBox.Items.Add(file);
                        videoListBox.SetItemChecked(videoListBox.Items.Count - 1, true);
                    }
                }
                Debug.WriteLine(file);
            }
        }

        private void subDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                var fileAttr = File.GetAttributes(file);
                if (fileAttr.HasFlag(FileAttributes.Directory))
                {
                    // Show files in that directory
                    foreach (var dirFile in Directory.GetFiles(file))
                    {
                        if (!MatchSub.FileShouldExclude(Path.GetFileName(dirFile)))
                        {
                            subListBox.Items.Add(dirFile);
                            subListBox.SetItemChecked(subListBox.Items.Count - 1, true);
                        }
                    }
                }
                else
                {
                    if (!MatchSub.FileShouldExclude(Path.GetFileName(file)))
                    {
                        subListBox.Items.Add(file);
                        subListBox.SetItemChecked(subListBox.Items.Count - 1, true);
                    }
                }
                Debug.WriteLine(file);
            }
        }

        private void videoDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void subDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void clearVideoBtn_Click(object sender, EventArgs e)
        {
            videoListBox.Items.Clear();
        }

        private void clearSubBtn_Click(object sender, EventArgs e)
        {
            subListBox.Items.Clear();
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            List<string> videoNames = new List<string>();
            List<string> subNames = new List<string>();
            List<string> subPath = subListBox.CheckedItems.Cast<string>().OrderBy(x => x).ToList();
            videoNames = videoListBox.CheckedItems.Cast<string>().Select(x => Path.GetFileName(x)).OrderBy(x => x).ToList();
            subNames = subListBox.CheckedItems.Cast<string>().Select(x => Path.GetFileName(x)).OrderBy(x => x).ToList();

            if (videoNames.Count != subNames.Count)
            {
                MessageBox.Show("Number of videos and subtitles does not match", "Warning");
                return;
            }

            if (videoNames.Count == 0 || subNames.Count == 0)
            {
                return;
            }

            var result = MatchSub.RenameSubtitles(videoNames, subNames);
            var subDestPath = Path.GetDirectoryName(subPath[0]);

            if (saveCopyCheckBox.Checked)
            {
                var dlg = new FolderPicker();
                if (dlg.ShowDialog(Handle) == true)
                {
                    subDestPath = dlg.ResultPath;
                }
                else return;
            }

            for (var i = 0; i < subPath.Count; i++)
            {
                if (saveCopyCheckBox.Checked)
                    File.Copy(subPath[i], Path.Combine(subDestPath, result[i]), true);
                else
                    File.Move(subPath[i], Path.Combine(subDestPath, result[i]), true);
            }

            MessageBox.Show("Subtitle renamed.", "OK");
        }
    }
}