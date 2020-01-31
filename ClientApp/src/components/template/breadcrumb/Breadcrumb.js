import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import { CATEGORY_URL_PREFIX } from './../../categories/Categories';


class Breadcrumb extends React.Component {

  render() {
    if (this.props.breadcrumbs === null) return null;

    return (
      <div id="breadcrumb" className="section">
        <div className="container">
          <div className="row">
            <div className="col-md-12">
              <ul className="breadcrumb-tree">
                <li>
                  <Link to="/">
                    Home
                </Link>
                </li>
                {this.props.breadcrumbs.map(({ name, url }, index) => {
                  if (index === this.props.breadcrumbs.length - 1) {
                    return (
                      <li key={url} className="active">
                        {name}
                      </li>
                    );
                  } else {
                    return (
                      <li key={url}>
                        <Link to={CATEGORY_URL_PREFIX + url}>
                          {name}
                        </Link>
                      </li>
                    );
                  }
                })}
              </ul>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = (state, ownProps) => ({
  breadcrumbs: state.breadcrumbsReducer.breadcrumbs
});

export default connect(mapStateToProps, null)(Breadcrumb);