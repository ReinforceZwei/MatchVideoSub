using System.Diagnostics;
using System.Windows.Forms;

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
            List<string> toAdd = new();
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
                            toAdd.Add(dirFile);
                        }
                    }
                }
                else
                {
                    if (!MatchSub.FileShouldExclude(Path.GetFileName(file)))
                    {
                        toAdd.Add(file);
                    }
                }
                Debug.WriteLine(file);
            }
            // Combine existing items
            toAdd.AddRange(videoListBox.Items.Cast<string>().ToList());
            videoListBox.Items.Clear();

            // Nature sorting the subtitles
            toAdd.OrderBy(x => x, new NaturalStringComparer())
                .ToList()
                .ForEach(x => videoListBox.Items.Add(x));

            for (int i = 0; i < videoListBox.Items.Count; i++)
            {
                videoListBox.SetItemChecked(i, true);
            }
        }

        private void subDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> toAdd = new();
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
                            toAdd.Add(dirFile);
                            //subListBox.SetItemChecked(subListBox.Items.Count - 1, true);
                        }
                    }
                }
                else
                {
                    if (!MatchSub.FileShouldExclude(Path.GetFileName(file)))
                    {
                        toAdd.Add(file);
                        //subListBox.SetItemChecked(subListBox.Items.Count - 1, true);
                    }
                }
                Debug.WriteLine(file);
            }
            // Combine existing items
            toAdd.AddRange(subListBox.Items.Cast<string>().ToList());
            subListBox.Items.Clear();

            // Nature sorting the subtitles
            toAdd.OrderBy(x => x, new NaturalStringComparer())
                .ToList()
                .ForEach(x => subListBox.Items.Add(x));

            for (int i = 0; i < subListBox.Items.Count; i++)
            {
                subListBox.SetItemChecked(i, true);
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
            List<string> videoPaths = videoListBox.CheckedItems.Cast<string>().ToList();
            List<string> subPaths = subListBox.CheckedItems.Cast<string>().ToList();

            if (videoPaths.Count == 0 || subPaths.Count == 0)
            {
                return;
            }

            if (saveCopyCheckBox.Checked)
            {
                var dlg = new FolderPicker();
                if (dlg.ShowDialog(Handle) == true)
                {
                    try
                    {
                        // Save a new copy
                        MatchSub.Match(videoPaths, subPaths, dlg.ResultPath);
                        MessageBox.Show("Subtitle saved.", "OK");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Number of videos and subtitles does not match", "Warning");
                        return;
                    }
                }
                else return;
            }
            else
            {
                try
                {
                    // Rename subtitles
                    MatchSub.Match(videoPaths, subPaths);
                    MessageBox.Show("Subtitle renamed.", "OK");
                }
                catch (Exception)
                {
                    MessageBox.Show("Number of videos and subtitles does not match", "Warning");
                    return;
                }
            }

            
        }
    }
}