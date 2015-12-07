# Orchard Content Types Readme



## Project Description

Contains some custom Orchard content types. Successor of the Hierarchical Pages module.


## Features

- Hierarchical Pages:
	- Hiearchical Page content type
	- Can contain other pages and can be contained
- Content Links:
	- Content Link items are links to other content items
	- Can be used to e.g. add links that point to ProjectionPages to a Projection


## Documentation

### Usage

After installation you'll see new features, each containing a content type:
- Hierarchical Pages: items of type Hierarchical Page can contain other such items and they're containable too (with the Container/Containable parts). The url slug of items will contain the slug of their parent by default.
- Content Links: content Link items are links to other content items that can be used to e.g. add links that point to ProjectionPages to a Projection.  

**See the [Version history](Docs/VersionHistory.md).**

You can install the module from the [Gallery](https://gallery.orchardproject.net/List/Modules/Orchard.Module.Piedone.ContentTypes).

The module's source is available in two public source repositories, automatically mirrored in both directions with [Git-hg Mirror](https://githgmirror.com):

- [https://bitbucket.org/Lombiq/orchard-content-types](https://bitbucket.org/Lombiq/orchard-content-types) (Mercurial repository)
- [https://github.com/Lombiq/Orchard-Content-Types](https://github.com/Lombiq/Orchard-Content-Types) (Git repository)

Bug reports, feature requests and comments are warmly welcome, **please do so via GitHub**.
Feel free to send pull requests too, no matter which source repository you choose for this purpose.

This project is developed by [Lombiq Technologies Ltd](http://lombiq.com/). Commercial-grade support is available through Lombiq.