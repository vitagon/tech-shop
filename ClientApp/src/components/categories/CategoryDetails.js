import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { getCategoryTree } from '../../actions/categoriesTreeActions';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faLaptop, faMobile } from '@fortawesome/free-solid-svg-icons';
import styles from './Categories.module.css';
import categoryDetailsStyles from './CategoryDetails.module.css';
import Breadcrumb from './../template/breadcrumb/Breadcrumb';
import { withRouter } from 'react-router-dom';
import { compose } from 'redux';
import { getBreadcrumbs } from './../../actions/breadcrumbsActions';
import { CATEGORY_URL_PREFIX, CATEGORY_GOODS_PAGE_URL_PREFIX } from './Categories';

class CategoryDetails extends React.Component {

  constructor(props) {
    super(props);
    this.props.getCategoryTree(this.props.match.params.categoryUrl);
    this.props.getBreadcrumbs(this.props.match.params.categoryUrl);
  }

  componentDidUpdate(prevProps, prevState) {
    if (prevProps.match.params.categoryUrl !== this.props.match.params.categoryUrl) {
      this.props.getCategoryTree(this.props.match.params.categoryUrl);
      this.props.getBreadcrumbs(this.props.match.params.categoryUrl);
    }
  }

  render() {
    if (this.props.categoryTree.length > 0) {
      let root = this.props.categoryTree[0];
      return (
        <>
          <Breadcrumb />

          <div className="container pb-5">
            <h1 className="mb-5">Categories of "{root.name}"</h1>

            {root.level === 1 && (
              <div className="row">
                {root.childrenList.map(x => {
                  let url = x.childrenList === null ?
                    CATEGORY_GOODS_PAGE_URL_PREFIX + x.url :
                    CATEGORY_URL_PREFIX + x.url;
                  return (
                    <div className="col-md-3" key={x.id}>
                      <div className={styles['subcat-lvl2_wrap']}>
                        <div className="col-md-3 p-0">
                          <div className={styles['subcat-img-wrap']}>
                            <FontAwesomeIcon icon={faMobile} />
                          </div>
                        </div>

                        <div className="col-md-9 p-0">
                          <Link to={url} className={styles['subcat-lvl2_link']}>{x.name}</Link>

                          {x.childrenList && x.childrenList.map(y => {
                            let url = y.childrenList === null ?
                              CATEGORY_GOODS_PAGE_URL_PREFIX + y.url :
                              CATEGORY_URL_PREFIX + y.url;
                            return (
                              <div className={styles['subcat-lvl3']} key={y.id}>
                                <Link to={url} className={styles['subcat-lvl3_link']}>{y.name}</Link>
                              </div>
                            )
                          })}
                        </div>
                      </div>
                    </div>
                  )
                })}
              </div>
            )}

            {root.level > 1 && (
              <div className={['row', categoryDetailsStyles['flat-categories']].join(' ')}>
                {root.childrenList && root.childrenList.map((category, index) => {
                  let url = category.childrenList === null ?
                    CATEGORY_GOODS_PAGE_URL_PREFIX + category.url :
                    CATEGORY_URL_PREFIX + category.url;
                  return (
                    <div className="col-xl-2dot4 col-md-3 p-4" key={index}>
                      <Link to={url}>
                        <img src={'/img/samsung-tvs.jpg'} className="img-fluid" />
                        <div className="mt-2 text-center">
                          <h5>{category.name}</h5>
                        </div>
                      </Link>
                    </div>
                  )
                })}
              </div>
            )}
          </div>
        </>
      );
    }
    return (<></>);
  }
}

const mapStateToProps = (state, ownProps) => ({
  categoryTree: state.categoriesReducer.categoryTree
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  getCategoryTree: getCategoryTree,
  getBreadcrumbs: getBreadcrumbs
}, dispatch);

export default compose(
  withRouter,
  connect(mapStateToProps, mapDispatchToProps)
)(CategoryDetails);