

	import {
		ClassicEditor,
		Autosave,
		Essentials,
		Paragraph,
		ImageEditing,
		ImageUtils,
		Title,
		HtmlComment,
		GeneralHtmlSupport,
		SourceEditing,
		ShowBlocks,
		TableCaption,
		Table,
		TableToolbar,
		PlainTableOutput,
		List,
		TodoList,
		ImageInline,
		ImageToolbar,
		ImageBlock,
		ImageUpload,
		CloudServices,
		Link,
		ImageInsertViaUrl,
		AutoImage,
		ImageStyle,
		LinkImage,
		ImageCaption,
		ImageTextAlternative,
		Heading,
		AutoLink,
		BlockQuote,
		HorizontalLine,
		CodeBlock,
		Indent,
		IndentBlock,
		Alignment,
		Highlight,
		FontSize,
		FontFamily,
		FontColor,
		FontBackgroundColor,
		Code,
		Bold,
		Italic,
		Underline,
		Strikethrough,
		Markdown,
		MediaEmbedStyle,
		MediaEmbed,
		MediaEmbedToolbar,
		Fullscreen,
		Autoformat,
		Mention,
		BalloonToolbar,
		BlockToolbar
} from '/lib/ckeditor/js/ckeditor5.js';;

	const LICENSE_KEY =
		'eyJhbGciOiJFUzI1NiJ9.eyJleHAiOjE3ODMyOTU5OTksImp0aSI6IjUxOWUxOTc4LTFiMTAtNDg3ZS1hNzAyLWI1NjViMDEyZWYwMCIsInVzYWdlRW5kcG9pbnQiOiJodHRwczovL3Byb3h5LWV2ZW50LmNrZWRpdG9yLmNvbSIsImRpc3RyaWJ1dGlvbkNoYW5uZWwiOlsiY2xvdWQiLCJkcnVwYWwiLCJzaCJdLCJ3aGl0ZUxhYmVsIjp0cnVlLCJsaWNlbnNlVHlwZSI6InRyaWFsIiwiZmVhdHVyZXMiOlsiKiJdLCJ2YyI6ImQxNDE2MThmIn0.19VmEDT3O8YNGUDQ_cyXS0IPL69Cm2NXnmN13qcaIXMHf5WiMCwrb4HdKG5zBDd59yZCdZ0NM7CFV8O6wrkURw';

	const editorConfig = {
		
		toolbar: {
			items: [
				'undo',
				'redo',
				'|',
				'sourceEditing',
				'showBlocks',
				'fullscreen',
				'|',
				'heading',
				'|',
				'fontSize',
				'fontFamily',
				'fontColor',
				'fontBackgroundColor',
				'|',
				'bold',
				'italic',
				'underline',
				'strikethrough',
				'code',
				'|',
				'horizontalLine',
				'link',
				'insertImageViaUrl',
				'mediaEmbed',
				'insertTable',
				'highlight',
				'blockQuote',
				'codeBlock',
				'|',
				'alignment',
				'|',
				'bulletedList',
				'numberedList',
				'todoList',
				'outdent',
				'indent'
			],
			shouldNotGroupWhenFull: false
		},
		plugins: [
			Alignment,
			Autoformat,
			AutoImage,
			AutoLink,
			Autosave,
			BalloonToolbar,
			BlockQuote,
			BlockToolbar,
			Bold,
			CloudServices,
			Code,
			CodeBlock,
			Essentials,
			FontBackgroundColor,
			FontColor,
			FontFamily,
			FontSize,
			Fullscreen,
			GeneralHtmlSupport,
			Heading,
			Highlight,
			HorizontalLine,
			HtmlComment,
			ImageBlock,
			ImageCaption,
			ImageEditing,
			ImageInline,
			ImageInsertViaUrl,
			ImageStyle,
			ImageTextAlternative,
			ImageToolbar,
			ImageUpload,
			ImageUtils,
			Indent,
			IndentBlock,
			Italic,
			Link,
			LinkImage,
			List,
			Markdown,
			MediaEmbed,
			MediaEmbedStyle,
			MediaEmbedToolbar,
			Mention,
			Paragraph,
			PlainTableOutput,
			ShowBlocks,
			SourceEditing,
			Strikethrough,
			Table,
			TableCaption,
			TableToolbar,
		
			TodoList,
			Underline
		],
		licenseKey: LICENSE_KEY,
		balloonToolbar: ['bold', 'italic', '|', 'link', '|', 'bulletedList', 'numberedList'],
		blockToolbar: [
			'fontSize',
			'fontColor',
			'fontBackgroundColor',
			'|',
			'bold',
			'italic',
			'|',
			'link',
			'insertTable',
			'|',
			'bulletedList',
			'numberedList',
			'outdent',
			'indent'
		],
		fontFamily: {
			supportAllValues: true
		},
		fontSize: {
			options: [10, 12, 14, 'default', 18, 20, 22],
			supportAllValues: true
		},
		fullscreen: {
			onEnterCallback: container =>
				container.classList.add(
					'editor-container',
					'editor-container_classic-editor',
					'editor-container_include-block-toolbar',
					'editor-container_include-fullscreen',
					'main-container'
				)
		},
		heading: {
			options: [
				{
					model: 'paragraph',
					title: 'Paragraph',
					class: 'ck-heading_paragraph'
				},
				{
					model: 'heading1',
					view: 'h1',
					title: 'Heading 1',
					class: 'ck-heading_heading1'
				},
				{
					model: 'heading2',
					view: 'h2',
					title: 'Heading 2',
					class: 'ck-heading_heading2'
				},
				{
					model: 'heading3',
					view: 'h3',
					title: 'Heading 3',
					class: 'ck-heading_heading3'
				},
				{
					model: 'heading4',
					view: 'h4',
					title: 'Heading 4',
					class: 'ck-heading_heading4'
				},
				{
					model: 'heading5',
					view: 'h5',
					title: 'Heading 5',
					class: 'ck-heading_heading5'
				},
				{
					model: 'heading6',
					view: 'h6',
					title: 'Heading 6',
					class: 'ck-heading_heading6'
				}
			]
		},
		htmlSupport: {
			allow: [
				{
					name: /^.*$/,
					styles: true,
					attributes: true,
					classes: true
				}
			]
		},
		image: {
			toolbar: ['toggleImageCaption', 'imageTextAlternative', '|', 'imageStyle:inline', 'imageStyle:wrapText', 'imageStyle:breakText']
		},
		link: {
			addTargetToExternalLinks: true,
			defaultProtocol: 'https://',
			decorators: {
				toggleDownloadable: {
					mode: 'manual',
					label: 'Downloadable',
					attributes: {
						download: 'file'
					}
				}
			}
		},
		mediaEmbed: {
			toolbar: ['mediaEmbed:breakText', 'mediaEmbed:wrapText']
		},
		mention: {
			feeds: [
				{
					marker: '@',
					feed: [
						/* See: https://ckeditor.com/docs/ckeditor5/latest/features/mentions.html */
					]
				}
			]
		},
		menuBar: {
			isVisible: true
		},
		table: {
			contentToolbar: ['tableColumn', 'tableRow', 'mergeTableCells']
		}
	};

export {
	ClassicEditor,
	editorConfig
};
