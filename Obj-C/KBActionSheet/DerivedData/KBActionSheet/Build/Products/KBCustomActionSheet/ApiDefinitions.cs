using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace KBCustomActionSheet
{
	// @interface KBActionSheet : UIView
	[BaseType (typeof(UIView))]
	interface KBActionSheet
	{
		// @property (nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) UIView * headerView;
		[Export ("headerView", ArgumentSemantic.Strong)]
		UIView HeaderView { get; set; }

		// @property (assign, nonatomic) KBActionSheetStyle style __attribute__((annotate("ui_appearance_selector")));
		[Export ("style", ArgumentSemantic.Assign)]
		KBActionSheetStyle Style { get; set; }

		// @property (assign, nonatomic) CGFloat dimmingViewAlpha __attribute__((annotate("ui_appearance_selector")));
		[Export ("dimmingViewAlpha")]
		nfloat DimmingViewAlpha { get; set; }

		// @property (assign, nonatomic) CGFloat maximumCompactWidth;
		[Export ("maximumCompactWidth")]
		nfloat MaximumCompactWidth { get; set; }

		// @property (copy, nonatomic) NSString * cancelButtonTitle;
		[Export ("cancelButtonTitle")]
		string CancelButtonTitle { get; set; }

		// @property (copy, nonatomic) void (^cancelButtonTappedBlock)();
		[Export ("cancelButtonTappedBlock", ArgumentSemantic.Copy)]
		Action CancelButtonTappedBlock { get; set; }

		// @property (nonatomic, strong) UIFont * buttonFont __attribute__((annotate("ui_appearance_selector")));
		[Export ("buttonFont", ArgumentSemantic.Strong)]
		UIFont ButtonFont { get; set; }

		// @property (nonatomic, strong) UIFont * cancelButtonFont __attribute__((annotate("ui_appearance_selector")));
		[Export ("cancelButtonFont", ArgumentSemantic.Strong)]
		UIFont CancelButtonFont { get; set; }

		// @property (nonatomic, strong) UIColor * buttonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("buttonBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ButtonBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * buttonTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("buttonTextColor", ArgumentSemantic.Strong)]
		UIColor ButtonTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * buttonTappedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("buttonTappedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ButtonTappedBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * buttonTappedTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("buttonTappedTextColor", ArgumentSemantic.Strong)]
		UIColor ButtonTappedTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * buttonSeparatorColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("buttonSeparatorColor", ArgumentSemantic.Strong)]
		UIColor ButtonSeparatorColor { get; set; }

		// @property (nonatomic, strong) UIColor * cancelButtonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("cancelButtonBackgroundColor", ArgumentSemantic.Strong)]
		UIColor CancelButtonBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * cancelButtonTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("cancelButtonTextColor", ArgumentSemantic.Strong)]
		UIColor CancelButtonTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * cancelButtonTappedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("cancelButtonTappedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor CancelButtonTappedBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * cancelButtonTappedTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("cancelButtonTappedTextColor", ArgumentSemantic.Strong)]
		UIColor CancelButtonTappedTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * destructiveButtonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("destructiveButtonBackgroundColor", ArgumentSemantic.Strong)]
		UIColor DestructiveButtonBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * destructiveButtonTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("destructiveButtonTextColor", ArgumentSemantic.Strong)]
		UIColor DestructiveButtonTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * destructiveButtonTappedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("destructiveButtonTappedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor DestructiveButtonTappedBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * destructiveButtonTappedTextColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("destructiveButtonTappedTextColor", ArgumentSemantic.Strong)]
		UIColor DestructiveButtonTappedTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * headerBackgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("headerBackgroundColor", ArgumentSemantic.Strong)]
		UIColor HeaderBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * titleColor __attribute__((annotate("ui_appearance_selector")));
		[Export ("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (nonatomic, strong) UIFont * titleFont __attribute__((annotate("ui_appearance_selector")));
		[Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// -(instancetype)initWithStyle:(KBActionSheetStyle)style;
		[Export ("initWithStyle:")]
		IntPtr Constructor (KBActionSheetStyle style);

		// -(instancetype)initWithTitle:(NSString *)title;
		[Export ("initWithTitle:")]
		IntPtr Constructor (string title);

		// -(instancetype)initWithHeaderView:(UIView *)headerView;
		[Export ("initWithHeaderView:")]
		IntPtr Constructor (UIView headerView);

		// -(void)addButtonWithTitle:(NSString *)title tappedBlock:(void (^)(void))tappedBlock;
		[Export ("addButtonWithTitle:tappedBlock:")]
		void AddButtonWithTitle (string title, Action tappedBlock);

		// -(void)addButtonWithTitle:(NSString *)title atIndex:(NSInteger)index tappedBlock:(void (^)(void))tappedBlock;
		[Export ("addButtonWithTitle:atIndex:tappedBlock:")]
		void AddButtonWithTitle (string title, nint index, Action tappedBlock);

		// -(void)removeButtonAtIndex:(NSInteger)index;
		[Export ("removeButtonAtIndex:")]
		void RemoveButtonAtIndex (nint index);

		// -(void)addDestructiveButtonWithTitle:(NSString *)title tappedBlock:(void (^)(void))tappedBlock;
		[Export ("addDestructiveButtonWithTitle:tappedBlock:")]
		void AddDestructiveButtonWithTitle (string title, Action tappedBlock);

		// -(void)removeDestructiveButton;
		[Export ("removeDestructiveButton")]
		void RemoveDestructiveButton ();

		// -(void)showFromRect:(CGRect)rect inView:(UIView *)view;
		[Export ("showFromRect:inView:")]
		void ShowFromRect (CGRect rect, UIView view);

		// -(void)showFromView:(UIView *)fromView inView:(UIView *)view;
		[Export ("showFromView:inView:")]
		void ShowFromView (UIView fromView, UIView view);

		// -(void)showFromBarButtonItem:(UIBarButtonItem *)barButtonItem inView:(UIView *)view;
		[Export ("showFromBarButtonItem:inView:")]
		void ShowFromBarButtonItem (UIBarButtonItem barButtonItem, UIView view);
	}
}
