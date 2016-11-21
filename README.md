# KBActionSheet

Custom and beautiful way of representing Actionsheet to your iOS project

###Usage

####Light Theme
```
BtnLight.TouchUpInside += (sender, e) => {
	KBActionSheet actionSheet = new KBActionSheet();
	actionSheet.Title = "A thing needs to be done.\nAre you sure you want to do it?";
	actionSheet.AddButtonWithTitle("Do Something", () => { });
	actionSheet.AddDestructiveButtonWithTitle("Do Nothing", () => {
		actionSheet.Dispose();
	});
	actionSheet.Style = KBActionSheetStyle.Light;
	actionSheet.ShowFromView(BtnLight, this.View);
};
```

####Dark Theme
```
BtnDark.TouchUpInside += (sender, e) => {
	KBActionSheet actionSheet = new KBActionSheet();
	actionSheet.Title = "A thing needs to be done.\nAre you sure you want to do it?";
	actionSheet.AddButtonWithTitle("Do Something", () => { });
	actionSheet.AddDestructiveButtonWithTitle("Do Nothing", () => {
		actionSheet.Dispose();
	});
	actionSheet.Style = KBActionSheetStyle.Dark;
	actionSheet.ShowFromView(BtnDark, this.View);
};
```

This is a binding project based on https://github.com/TimOliver/TOActionSheet
