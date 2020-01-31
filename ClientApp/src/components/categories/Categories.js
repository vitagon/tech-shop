import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { getCategoriesTreeFromRoot } from '../../actions/categoriesTreeActions';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faLaptop, faMobile } from '@fortawesome/free-solid-svg-icons';
import styles from './Categories.module.css';
import Breadcrumb from './../template/breadcrumb/Breadcrumb';
import _ from 'lodash';
import { getBreadcrumbs } from '../../actions/breadcrumbsActions';

export const CATEGORY_URL_PREFIX = '/d/';
export const CATEGORY_GOODS_PAGE_URL_PREFIX = '/c/';

class Categories extends React.Component {

  constructor(props) {
    super(props);
    this.props.getCategoriesTreeFromRoot();
    this.props.getBreadcrumbs();
  }

  render() {
    if (this.props.categoriesTree.length > 0) {
      let root = this.props.categoriesTree[0];
      return (
        <>
          <Breadcrumb />

          <div className="container">
            <h1 className="mb-5">Categories of products of "TechShop"</h1>

            {root.childrenList.map(x => {
              let url = x.childrenList === null ?
                CATEGORY_GOODS_PAGE_URL_PREFIX + x.url :
                CATEGORY_URL_PREFIX + x.url;
              return (
                <div className="row mb-5 pb-5" key={x.id}>
                  <div className="col-md-12 mb-3">
                    <div className={styles['cat-header']}>
                      <div className={styles['img-wrap']}>
                        <FontAwesomeIcon icon={faLaptop} />
                      </div>
                      <Link to={url} className={styles['cat_link']}>{x.name}</Link>
                    </div>
                  </div>

                  {x.childrenList.map(y => {
                    let url = y.childrenList === null ?
                      CATEGORY_GOODS_PAGE_URL_PREFIX + y.url :
                      CATEGORY_URL_PREFIX + y.url;
                    return (
                      <div className="col-md-3" key={y.id}>
                        <div className={styles['subcat-lvl2_wrap']}>
                          <div className="col-md-3 p-0">
                            <div className={styles['subcat-img-wrap']}>
                              <FontAwesomeIcon icon={faMobile} />
                            </div>
                          </div>

                          <div className="col-md-9 p-0">
                            <Link to={url} className={styles['subcat-lvl2_link']}>{y.name}</Link>

                            {y.childrenList && y.childrenList.map(z => {
                              let url = z.childrenList === null ?
                                CATEGORY_GOODS_PAGE_URL_PREFIX + z.url :
                                CATEGORY_URL_PREFIX + z.url;
                              return (
                                <div className={styles['subcat-lvl3']} key={z.id}>
                                  <Link to={url} className={styles['subcat-lvl3_link']}>{z.name}</Link>
                                </div>
                              )
                            })}
                          </div>
                        </div>
                      </div>
                    )
                  })}
                </div>
              )
            })}
          </div>
        </>
      );
    }
    return (<></>);
  }
}

const mapStateToProps = (state, ownProps) => ({
  categoriesTree: state.categoriesReducer.categoriesTree
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  getCategoriesTreeFromRoot: getCategoriesTreeFromRoot,
  getBreadcrumbs: getBreadcrumbs
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(Categories);
